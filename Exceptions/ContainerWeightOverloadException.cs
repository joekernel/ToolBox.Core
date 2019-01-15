using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ToolBox.Core.Exceptions
{
    public class ContainerWeightOverloadException : Exception
    {
        public ContainerWeightOverloadException(Guid containerId):base(containerId.ToString())
        {
        }

        public ContainerWeightOverloadException(string message) : base(message)
        {
        }

        public ContainerWeightOverloadException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ContainerWeightOverloadException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
