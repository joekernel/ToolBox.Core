using System;

namespace ToolBox.Core.Interfaces
{
    public interface ITool
    {
        Guid Id { get; }
        string Name { get; }
        double Weight { get; }
        double Capacity { get; }
        string Category { get; }
    }
}
