using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Demo.Functions
{
    public class SquareRootFunction : IFunction
    {
        public int Calculate(int number)
        {
            return (int)Math.Sqrt(number);
        }
    }
}
