using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToolBox.Core.Entities;
using ToolBox.Infrastructure.Interfaces;

namespace ToolBox.Core.Interfaces
{
    public interface IAsyncRepository<T> where T:IMongoEntity
    {
        Task<Container> GetById(Guid id);
        Task Update(T entity);
        Task AddNew(T entity);
        Task<IEnumerable<T>> ListAll();
    }
}
