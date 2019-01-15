using Ardalis.GuardClauses;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Core.Entities;
using ToolBox.Core.Interfaces;

namespace ToolBox.Core.Services
{
    public class ContainerSerivce:IContainerService
    {
        private readonly IAsyncRepository<Container> _containerRepository;

        public ContainerSerivce(IAsyncRepository<Container> containerRepository)
        {
            _containerRepository = containerRepository;
        }

        public async Task AddItemToContainer(Guid containerId, Tool item, int quantity)
        {
            var container = await _containerRepository.GetById(containerId);

            Guard.Against.ContainerNotFound(container, containerId);

            container.AddItem(item, quantity);

            await _containerRepository.Update(container);
        }

        public async Task DeleteItemFromContainer(Guid containerId, Guid itemId)
        {
            var container = await _containerRepository.GetById(containerId);

            Guard.Against.ContainerNotFound(container, containerId);

            container.Items.RemoveAll(q => q.ItemId == itemId);

            await _containerRepository.Update(container);
        }
    }
}
