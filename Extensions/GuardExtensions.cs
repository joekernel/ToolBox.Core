using System;

namespace Ardalis.GuardClauses
{
    public static class GuardExtensions
    {
        public static void ContainerCapacityOverload(this IGuardClause guardClause, double capacity,double maxCapacity)
        {
            if (maxCapacity < capacity)
                throw new Exception($"The container capacity is overloaded, you can't add this item.");
        }

        public static void ContainerWeightOverload(this IGuardClause guardClause,double weight, double maxWeight)
        {
            if (maxWeight < weight)
                throw new Exception($"The container weight is overloaded, you can't add this item.");
        }
    }
}
