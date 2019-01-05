using System;
using System.Collections.Generic;
using System.Text;

namespace ToolBox.Core.Entities
{
    public class Tool
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public double Capacity { get; private set; }
        public string Category { get; private set; }
    }
}
