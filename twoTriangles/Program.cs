using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_triangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter triangle height");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.Write("#");
                
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = a; i > 0; i--)
            {
                Console.Write("#");

                for (int j = i; j > 1; j--)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            //////////////////////////////////////////////////////////
            for (int i = 0; i < a; i++)
            {
                

                for (int j = a; j > i + 1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = i; j >= 0; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = a; i > 0; i--)
            {
                for (int j = a; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = i; j > 0; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
