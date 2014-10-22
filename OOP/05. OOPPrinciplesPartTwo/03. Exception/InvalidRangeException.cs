using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class InvalidRangeExeption<T> : ApplicationException
    {
        public T fromT { get; set; }
        public T toT { get; set; }

        public InvalidRangeExeption(string msg, T min, T max)
            : base(msg)
        {
            this.fromT = min;
            this.toT = max;
        }
    }
}
