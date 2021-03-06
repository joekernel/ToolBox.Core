﻿using System;

namespace ToolBox.Core.Entities
{
    public class ContainerItem
    {
        public Guid ItemId { get; set; }
        public double ItemWeight { get; private set; }
        public double ItemCapacity { get; private set; }
        public double ContainerItemCapacity { get; private set; }
        public double ContainerItemWeight { get; private set; }
        public int Quantity { get; private set; }

        public ContainerItem(Guid itemId, double capacity, double weight,int quantity=1)
        {
            ItemId = itemId;
            ItemCapacity = capacity;
            ItemWeight = weight;
            Quantity = quantity;
            ContainerItemCapacity = quantity * capacity;
            ContainerItemWeight = quantity * weight;
        }

        public void IncreaseQuantity(int quantity)
        {
            Quantity += quantity;
            ContainerItemCapacity=CalculateCapacity();
            ContainerItemWeight=CalculateWeight();
        }

        private double CalculateCapacity() => ContainerItemCapacity += Quantity * ItemCapacity;

        private double CalculateWeight() => ContainerItemWeight += Quantity * ItemWeight;
    }
}
