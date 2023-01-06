using Interfaces.Demo.Functions;

namespace Interfaces.Demo
{
    public class Calculator
    {
        // Strategy pattern
        public void Calculate(int[] numbers, IFunction function)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = function.Calculate(numbers[i]);
            }
        }
    }
}
