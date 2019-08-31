using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace metalwolfchaosxd2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var nums = input.Split(",");

            var extraNums = new List<int>();

            foreach (string number in nums)
            {
                var currNum = Convert.ToInt32(number);
                extraNums.Add(currNum);
            }

            foreach (int number in extraNums)
            {
                var lol = number.Count;
            }

            Console.WriteLine();

        }
    }
}
