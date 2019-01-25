using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    //7
    class AquIndexOutOfRangeException : Exception
    {
        public AquIndexOutOfRangeException() : base("Нет акулы в такой клетке") { }
    }
    //
}
