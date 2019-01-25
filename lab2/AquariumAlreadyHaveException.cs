using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class AquariumAlreadyHaveException : Exception
    {
        public AquariumAlreadyHaveException() : base("Уже есть такая акула") { }
    }
}
