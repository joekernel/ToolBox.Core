using System;
using System.Collections.Generic;
using System.Text;
using ToolBox.Core.Entities;

namespace ToolBox.Core.Interfaces
{
    public interface IContainer
    {
        Guid Id { get; }
        double ContainerMaxCapacity { get; }
        double ContainerMaxWeight { get; }
        double ContainerCapacity { get; }
        double ContainerWeight { get; }
        List<ContainerItem> Items { get; }
        void AddItem(Tool item, int quantity = 1);
    }
}
