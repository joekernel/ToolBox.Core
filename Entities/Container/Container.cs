using Ardalis.GuardClauses;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;  
using ToolBox.Infrastructure.Interfaces;    

namespace ToolBox.Core.Entities
{
    public class Container : Interfaces.IContainer, IMongoEntity
    {
        [BsonId]
        public Guid Id { get; private set; }
        public double ContainerMaxCapacity { get; private set; }
        public double ContainerMaxWeight { get; private set; }
        public double ContainerCapacity { get; private set; }
        public double ContainerWeight { get; private set; }
        public List<ContainerItem> Items { get; private set; }

        public void AddItem(Tool item, int quantity = 1)
        {
            Guard.Against.ContainerCapacityOverload(ContainerCapacity + quantity * item.Capacity, ContainerMaxCapacity);
            Guard.Against.ContainerWeightOverload(this,quantity * item.Weight);

            var existingItem = Items.FirstOrDefault(i => i.ItemId == item.Id);

            if (existingItem != null)
                existingItem.IncreaseQuantity(quantity);
            else
                Items.Add(new ContainerItem(item.Id, item.Capacity, item.Weight, quantity));
        }
    }
}
