using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesAndEvents
{
    public delegate T Formula<T>(T num1, T num2);

    public class CalculatorClass
    {
        public double getSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double getDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public double getProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public double getQuotient(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
        public Formula<double>? eventHandler;
        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Adding a Delegate.");
                eventHandler += value;
            }
            remove
            {
                Console.WriteLine("Removed a Delegate.");
                eventHandler -= value;
            }
        }
    }
}