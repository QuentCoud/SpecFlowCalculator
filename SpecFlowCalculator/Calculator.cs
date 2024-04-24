using System;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public List<int> numbers { get; set; }
        
        public Calculator()
        {
            numbers = new List<int>();
        }
        public int Add()
        {
            int result = 0;
            foreach (int num in numbers)
            {
                result += num;
            }
            return result;
        }

        public int Multiply()
        {
            int result = 1;
            foreach (int num in numbers)
            {
                result *= num;
            }
            return result;
        }

        public double Divide()
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                result /= numbers[i];
            }
            return result;
        }
    }
}