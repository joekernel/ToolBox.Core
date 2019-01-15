using MongoDB.Bson;
using System;
using ToolBox.Core.Entities;
using ToolBox.Core.Exceptions;

namespace Ardalis.GuardClauses
{
    public static class GuardExtensions
    {
        public static void ContainerCapacityOverload(this IGuardClause guardClause, double capacity, double maxCapacity)
        {
            if (maxCapacity < capacity)
                throw new Exception($"The container capacity is overloaded, you can't add this item.");
        }

        public static void ContainerWeightOverload(this IGuardClause guardClause, Container container, double weight)
        {
            if (container.ContainerMaxWeight < container.ContainerWeight+weight)
                throw new ContainerWeightOverloadException(container.Id);
        }

        public static void ContainerNotFound(this IGuardClause guardClause, Container container, Guid containerId)
        {
            if (container == null)
                throw new Exception($"Container not found");
        }
    }
}
