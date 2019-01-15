using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Core.Entities;

namespace ToolBox.Core.Interfaces
{
    public interface IContainerService
    {
        Task AddItemToContainer(Guid containerId, Tool item, int quantity);
        Task DeleteItemFromContainer(Guid containerId, Guid itemId);
    }
}
