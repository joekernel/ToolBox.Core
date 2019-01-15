using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Core.Entities;
using ToolBox.Core.Interfaces;
using ToolBox.Infrastructure.Interfaces;

namespace ToolBox.Core
{
    public class ContainerRepository : IAsyncRepository<Container>
    {
        private readonly IMongoRepository<Container> _mongoRepository;

        public ContainerRepository(IMongoRepository<Container> mongoRepository)
        {
            _mongoRepository = mongoRepository;
        }

        public async Task AddNew(Container entity)
        {
            await _mongoRepository.Add(entity);
        }

        public async Task<Container> GetById(Guid id)
        {
            return await _mongoRepository.GetById(id);
        }

        public Task<IEnumerable<Container>> ListAll()
        {
            throw new NotImplementedException();
        }

        public async Task Update(Container entity)
        {
            await _mongoRepository.Update(entity);
        }
    }
}
