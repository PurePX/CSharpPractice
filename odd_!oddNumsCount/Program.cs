using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd__odd_nums_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                int num1;
                int num2;
                bool isGreater;
                int oddSum = 0;
                int evenSum = 0;
                int oddCount = 0;
                int evenCount = 0;
                Console.Clear();
                try
                {
                    Console.WriteLine("vvedite 1 4islo (int)");
                    num1 = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("VVEDITE INT");
                    Console.ReadLine();
                    continue;
                }

                try
                {
                    Console.WriteLine("vvedite 2 4islo (int)");
                    num2 = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("VVEDITE INT");
                    Console.ReadLine();
                    continue;
                }
                if (num1 > num2)
                {
                    isGreater = false;
                }
                else
                { 
                    isGreater = true;
                }

                switch (isGreater)
                {
                    case true:
                        {
                            for (int i = num1; i < num2 + 1; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    oddSum += i;
                                    oddCount++;
                                }
                                else
                                {
                                    evenSum += i; 
                                    evenCount++;
                                }
                            }
                            break;
                        }
                    case false:
                        {
                            for (int i = num2; i < num1 + 1; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    oddSum += i;
                                    oddCount++;
                                }
                                else
                                {
                                    evenSum += i;
                                    evenCount++;
                                }
                            }
                            break;
                        }
                        
                        

                }
                Console.WriteLine("oddCount = " + oddCount);
                Console.WriteLine("evenCount = " + evenCount);
                Console.WriteLine("oddSum = " + oddSum);
                Console.WriteLine("evenSum = " + evenSum);
                Console.ReadLine();
            }
        }
    }
}
