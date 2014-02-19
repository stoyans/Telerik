using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DefineExceptionClass
{
    public class InvalidRangeException<T> : Exception
    {

        public InvalidRangeException(string message, T startRange, T endRange)
            : base(message)
        {
            this.Start = startRange;
            this.End = endRange;
        }

        public T Start { get; set; }
        public T End { get; set; }

        public override string Message
        {
            get
            {
                string result = string.Format("The value is out of the range {0} - {1}", this.Start, this.End);
                return result;
            }
        }
    }
}
