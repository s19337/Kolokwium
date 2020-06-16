using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Kolokwium2.Exceptions
{
    public class TrackDoesNotExistsException : Exception
    {
        public TrackDoesNotExistsException()
        {
        }

        public TrackDoesNotExistsException(string message) : base(message)
        {
        }

        public TrackDoesNotExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
