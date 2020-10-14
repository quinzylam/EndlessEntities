using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace EndlessEntities.Core.Services
{
    public interface IEntityService<T>
    {
        Task<bool> AddAsync(T model);

        Task<bool> UpdateAsync(T model);

        Task<bool> DeleteAsync(string id);

        Task<T> GetAsync(string id);

        Task<IEnumerable<T>> GetAsync();
    }
}