using System;
using System.Collections.Generic;

namespace ChallengeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = "0100110";
            var test2 = "001011011101001001000";
            var test3 = "1010010101001011011001011101111";
            var test4 = "1101110110000001010111011100110";
            var result = Flip(test);
            Console.WriteLine(String.Format("Test: {0}, Answer: {1}", test, result));

            result = Flip(test2);
            Console.WriteLine(String.Format("Test: {0}, Answer: {1}", test2, result));

            result = Flip(test3);
            Console.WriteLine(String.Format("Test: {0}, Answer: {1}", test3, result));

            result = Flip(test4);
            Console.WriteLine(String.Format("Test: {0}, Answer: {1}", test4, result));           
            
        }

        public static string Flip(string underTest)
        {
            var order = new List<int>();
            var isTheNextCardHigher = false;

            for (int i = 0; i < underTest.Length; i++)
            {
                var card = underTest[i];
                if (isTheNextCardHigher)
                {
                    order.Add(i);
                } 
                else
                {
                    order.Insert(0, i);
                }

                isTheNextCardHigher ^= card == '1';
            }
            var returnValue = string.Empty;
            if (isTheNextCardHigher)
            {
                returnValue = String.Concat(order);
            }
            else
            {
                returnValue = "No Solution";
            }

            return returnValue;
        }
    }
}
