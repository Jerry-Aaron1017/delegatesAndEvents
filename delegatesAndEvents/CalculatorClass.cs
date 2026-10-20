using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace delegatesAndEvents
{
    public delegate T Formula<T, R>(T num1, T num2, R operation);

    class CalculatorClass
    {
        public static double getSum(double num1, double num2, string operation)
        {
            return num1 + num2;
        }

        public static double getDifference(double num1, double num2, string operation)
        {
            return num1 - num2;
        }

        public static double getProduct(double num1, double num2, string operation)
        {
            return num1 * num2;
        }

        public static double getQuotient(double num1, double num2, string operation)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }

        public delegate double CalculateEvent(double num1, double num2);

        public class EventAccessorClass
        {
            public CalculateEvent Sum;
            public event CalculateEvent CalculateSumEvent
            {
                add
                {
                    Console.WriteLine("Adding a method to the event.");
                    Sum += value;
                }
                remove
                {
                    Console.WriteLine("Removing a method from the event.");
                    Sum -= value;
                }
            }

        }
    }
}
