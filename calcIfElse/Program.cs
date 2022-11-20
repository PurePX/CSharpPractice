using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Calc_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {while (true) 
            {
                string action;
                double num1;
                double num2;
                Console.Clear();
                try
                {
                    Console.WriteLine("enter first number");
                    num1 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR: Not a number");
                    Console.ReadLine();
                    continue;
                }
                
                do
                {
                    Console.WriteLine("Which operation? + - * /");
                    action = Console.ReadLine();
                    if (action != "+" && action != "-" && action != "*" && action != "/")
                    {
                        Console.WriteLine("Unknown operator");
                    }
                    else
                        break;
                } while (action != "+" && action != "-" && action != "*" && action != "/");

                try
                {
                Console.WriteLine("Enter second number");
                num2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR: Not a number");
                    Console.ReadLine();
                    continue;
                }
                double result;
                if (action == "+")
                {
                    result = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2 + " = " + result);
                }

                else if (action == "-")
                {
                    result = num1 - num2;
                    Console.WriteLine(num1 + " - " + num2 + " = " + result);
                }

                else if (action == "*")
                {
                    result = num1 * num2;
                    Console.WriteLine(num1 + " * " + num2 + " = " + result);
                }

                else if (action == "/")
                {
                    if (num2 == 0 && num1 != 0)
                    {
                        Console.WriteLine("ERROR: Division by zero!");
                    }
                    else
                    {
                        result = num1 / num2;   
                        Console.WriteLine(num1 + " / " + num2 + " = " + result);
                    }
                }
                else
                    {
                        Console.WriteLine("Unknown operator");
                    }
                Console.ReadLine();
            }


        }
    }
}
