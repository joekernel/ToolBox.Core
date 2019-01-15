using MongoDB.Bson.Serialization.Attributes;
using System;
using ToolBox.Infrastructure.Interfaces;

namespace ToolBox.Core.Entities
{
    public class Tool : IMongoEntity
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public double Capacity { get; private set; }
        public string Category { get; private set; }
    }
}
