using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            string action;
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Enter first number");
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

                switch (action)
                {
                    case "+":
                        {
                            result = num1 + num2;
                            Console.WriteLine(num1 + " + " + num2 + " = " + result);
                            break;
                        }
                    case "-":
                        {
                            result = num1 - num2;
                            Console.WriteLine(num1 + " - " + num2 + " = " + result);
                            break;
                        }
                    case "*":
                        {
                            result = num1 * num2;
                            Console.WriteLine(num1 + " * " + num2 + " = " + result);
                            break;
                        }
                    case "/":
                        {
                            if (num2 == 0 && num1 != 0)
                            {
                                Console.WriteLine("ERROR: Division by zero");
                                break;
                            }
                            else
                            {
                                result = num1 / num2;
                                Console.WriteLine(num1 + " / " + num2 + " = " + result);
                                break;
                            }
                        }
                    default:
                        {
                            Console.WriteLine("Unknown operator");
                            break;
                        }
                 
                }
                Console.ReadLine();
            }
        }
    }
}
