using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int min = 0;
            Console.Write("enter elements count: ");
            int elementsCount = int.Parse(Console.ReadLine());
            int[] array = new int[elementsCount];
            for (int i = 0; i < elementsCount; i++)
            {
                Console.WriteLine("enter array element number " + i);
                array[i] = int.Parse(Console.ReadLine());
            }               
            Console.WriteLine("array back to forth:");
            min = array[array.Length - 1];
            for (int i = array.Length - 1; i>= 0; i--)
            {
                Console.WriteLine(array[i]);
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("sum of even numbers = " + sum);
            Console.WriteLine("min array number = " + min);
            Console.ReadLine();
        }
        
    }
}
