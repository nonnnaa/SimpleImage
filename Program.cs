using System;
namespace Program
{
    class Solve
    {
        static void Main(string[] s)
        {
            while(true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. Print the square triangle (The corner is square at 4 different angles: top-left, top-right, botton-left, botton-right)");
                Console.WriteLine("3. Print isosceles triangle");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1)
                {
                    // hinh chu nhat co chieu dai = 6 , chieu rong = 3
                    for(int i=0 ; i<3 ; i++)
                    {
                        for(int j=0 ; j<6 ; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                else if(choice == 2)
                {
                    // tam giac vuong co canh n = 5
                    Console.WriteLine("Square triangle at top-left");
                    for(int i=5 ; i>0 ; i--)
                    {
                        for(int j=0 ; j<i ; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    Console.WriteLine("Square triangle at top-right");
                    for(int i=0 ; i<5 ; i++)
                    {
                        for(int j=0 ; j<5 ; j++)
                        {
                            if(j < i) Console.Write(" ");
                            else Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    Console.WriteLine("Square triangle at bottom-left");
                    for(int i=0 ; i<5 ; i++)
                    {
                        for(int j=0 ; j<5 ; j++)
                        {
                            if(j > i) Console.Write(" ");
                            else Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    Console.WriteLine("Square triangle at bottom-right");
                    for(int i=0 ; i<5 ; i++)
                    {
                        for(int j=0 ; j<5 ; j++)
                        {
                            if(i + j >= 5 - 1) Console.Write("*");
                            else Console.Write(" ");
                        }
                        Console.Write("\n");
                    }
                }
                else if(choice == 3)
                {
                    Console.WriteLine("Isosceles triangle");
                    // tam giac can tren n dong (n = 4)
                    for(int i=0 ; i<4 ; i++)
                    {
                        for(int j=0 ; j<(i + 4) ; j++)
                        {
                            if(i + j >= 4 - 1)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.Write("\n");
                    }
                }
                else
                {
                    Console.WriteLine("End");
                    break;
                }
            }
        }
    }
}