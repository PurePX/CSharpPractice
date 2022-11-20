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
                    Console.WriteLine("1vvedite 4islo");
                    num1 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Eto ne 4islo!!");
                    Console.ReadLine();
                    continue;
                }
                do
                {
                    Console.WriteLine("2operaciya + - * /");
                    action = Console.ReadLine();
                    if (action != "+" && action != "-" && action != "*" && action != "/")
                    {
                        Console.WriteLine("3neizvestnoye deistviye");
                    }
                    else
                        break;
                } while (action != "+" && action != "-" && action != "*" && action != "/");

                try
                {
                    Console.WriteLine("4vvedite vtoroye 4islo");
                    num2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Eto ne 4islo!!");
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
                                Console.WriteLine("На ноль делить нельзя!");
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
                            Console.WriteLine("Неизвестное действие");
                            break;
                        }
                 
                }
                Console.ReadLine();
            }
        }
    }
}
