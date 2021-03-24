using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Список из последних цифр числа.

            /*List<int> numbers = new List<int>() { 23, 7, 324, 46 };
            List<int> newnumbers = new List<int>() { };
            foreach (var n in numbers)
            {
                int last = n % 10;
                newnumbers.Add(last);
            }
            foreach (var last in newnumbers)
            {
                Console.Write(last);
            }*/
            
            //2. Подсчет количества элементов в списке.

            List<int> numbers = new List<int>() { 1, 2, 1, 4, 2, 5, 6, 3, 3, 1 };
           
            foreach (int n in numbers.Distinct())
            {
                Console.WriteLine(n + " - встречается " + numbers.Where(x => x == n).Count() + " раз(а)");
            }



        }
    }
}
