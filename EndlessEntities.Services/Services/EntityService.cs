using EndlessEntities.Core.Models;
using EndlessEntities.Core.Services;
using EndlessEntities.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EndlessEntities.Services.Services
{
    public class EntityService : IEntityService<Entity>
    {
        private readonly IDataStore<Entity> _dataStore;

        public EntityService(IDataStore<Entity> dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<bool> AddAsync(Entity model)
        {
            return await _dataStore.AddItemAsync(model);
        }

        public async Task<bool> DeleteAsync(string id)
        {
            return await _dataStore.DeleteItemAsync(id);
        }

        public async Task<Entity> GetAsync(string id)
        {
            return await _dataStore.GetItemAsync(id);
        }

        public async Task<IEnumerable<Entity>> GetAsync()
        {
            return await _dataStore.GetItemsAsync();
        }

        public async Task<bool> UpdateAsync(Entity model)
        {
            return await _dataStore.UpdateItemAsync(model);
        }
    }
}