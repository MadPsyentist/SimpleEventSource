using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SimpleEventSource.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SimpleEventSource.Persistence {
	public class EfCoreAsyncEventRepository<TEntity, TDbContext> : IAsyncEventRepository<TEntity>
		where TEntity : Entity
		where TDbContext : DbContext, ISimpleEventSourceDbContext
	{
		Dictionary<string, Type> actions;
		ISimpleEventSourceDbContext context;

		public EfCoreAsyncEventRepository(ISimpleEventSourceDbContext context, IAction<TEntity>[] possibleActions) {
			this.context = context;
			actions = new Dictionary<string, Type>(possibleActions.Length);
			foreach (var action in possibleActions) {
				AddAction(action);
			}
		}

		public void AddAction(IAction<TEntity> action) {
			actions.Add(action.GetType().Name, action.GetType());
		}

		public async Task SaveAction(int entityId, IAction<TEntity> action) { 
			throw new NotImplementedException();
		}

		public async Task<int[]> GetEntityIds() {
			return await context.GetEvents()
				.Select(x => x.EntityId)
				.Distinct()
				.ToArrayAsync();
		}

		public async Task<TEntity> GetEntity(int id) {
			throw new NotImplementedException();
		}

		private async Task<EventDBO> BuildEntityEventFromEvent(TEntity entity, IAction<TEntity> action) {
			string serializedData = JsonConvert.SerializeObject(action);
			int version = await GetNextEventVersion(entity.Id);
			string eventType = newEvent.GetType().Name;
			return new EntityEvent(entity.Id, version, DateTime.Now, eventType, serializedData);
		}

		private async Task<int> getNextEntityVersion(int entityId) {
			var currentEntityVersion = await context.GetEvents()
				.Where(x => x.EntityId == entityId)
				.MaxAsync(x => x.EntityVersion);
			return currentEntityVersion++;
		}

		public async Task<int> GetNewEntityId() {
			int[] ids = await GetEntityIds();
			return ids.Max()++;
		}
	}
}