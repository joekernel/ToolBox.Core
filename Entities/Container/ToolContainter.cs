using Ardalis.GuardClauses;
using System.Collections.Generic;
using System.Linq;

namespace ToolBox.Core.Entities
{
    public class ToolContainter
    {
        public int ContainerId { get; }
        public double ContainerMaxCapacity { get; private set; }
        public double ContainerMaxWeight { get; private set; }
        public double ContainerCapacity { get; private set; }
        public double ContainerWeight { get; private set; }

        private readonly List<ContainerItem> _items = new List<ContainerItem>();
        public IReadOnlyList<ContainerItem> Items => _items.AsReadOnly();

        public void AddItem(Tool item, int quantity = 1)
        {
            Guard.Against.ContainerCapacityOverload(ContainerCapacity+quantity*item.Capacity,ContainerMaxCapacity);
            Guard.Against.ContainerWeightOverload(ContainerWeight+quantity*item.Weight,ContainerMaxWeight);

            var existingItem = _items.FirstOrDefault(i => i.ItemId == item.Id);

            if (existingItem != null)
                existingItem.IncreaseQuantity(quantity);
            else
                _items.Add(new ContainerItem(item.Id,item.Capacity,item.Weight,quantity));
        }
    }
}
