// SwapMinMax

// first task 

using System;

namespace MinMax
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first value");
            int firtsValue = Convert.ToInt(Console.ReadLine());
            Console.WriteLine("Enter second value");
            int secondValue = Convert.ToInt(Console.ReadLine());
            Console.WriteLine("Enter third value");
            int thirdValue = Convert.ToInt(Console.ReadLine());
            Console.WriteLine("Enter fourth value");
            int fourthValue = Convert.ToInt(Console.ReadLine());

            int[] array = { firtsValue, secondValue, thirdValue, fourthValue };

            int minValue = array.Min();
            int maxValue = array.Max();

            int counter = 1;

            for (int i = 0; i < 4; i++)
            {
                if (array[i] == minValue && array[i] == maxValue)
                {
                    Console.WriteLine($"x{counter} = {array[i]}  min/max");
                    counter++;
                }

                else if (array[i] == minValue)
                {
                    array[i] = maxValue;
                    Console.WriteLine($"x{counter} = {array[i]}  max");
                    counter++;
                }

                else if (array[i] == maxValue)
                {
                    array[i] = minValue;
                    Console.WriteLine($"x{counter} = {array[i]}  min");
                    counter++;
                }

                else
                {
                    Console.WriteLine($"x{counter} = {array[i]}");
                    counter++;
                }
            }
        }
    }
