using EndlessEntities.Core.Models;
using EndlessEntities.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EndlessEntities.UI.Controllers
{
    public class EntityController
    {
        private readonly IEntityService<Entity> _entityService;

        public EntityController(IEntityService<Entity> entityService)
        {
            _entityService = entityService;
        }

        public async Task<IEnumerable<Entity>> GetAsync()
        {
            return await _entityService.GetAsync();
        }

        public async Task<Entity> GetAsync(string id)
        {
            return await _entityService.GetAsync(id);
        }

        public async Task<bool> AddAsync(Entity entity)
        {
            return await _entityService.AddAsync(entity);
        }

        public async Task<bool> UpdateAsync(Entity entity)
        {
            return await _entityService.UpdateAsync(entity);
        }

        public async Task<bool> DeleteAsync(string id)
        {
            return await _entityService.DeleteAsync(id);
        }
    }
}