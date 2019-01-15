using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Core.Entities;
using ToolBox.Core.Interfaces;
using ToolBox.Infrastructure.Interfaces;

namespace ToolBox.Core.Repositories
{
    public class ToolBoxRepository : IAsyncRepository<Tool>
    {
        private IMongoRepository<Tool> _mongoRepository;

        public ToolBoxRepository(IMongoRepository<Tool> mongoRepository)
        {
            _mongoRepository = mongoRepository;
        }

        public Task AddNew(Tool entity)
        {
            throw new NotImplementedException();
        }

        public Task<Container> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async  Task<IEnumerable<Tool>> ListAll()
        {
            return await _mongoRepository.ListAll();
        }

        public Task Update(Tool entity)
        {
            throw new NotImplementedException();
        }
    }
}
