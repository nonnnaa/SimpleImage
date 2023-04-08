using System;
namespace Program
{
    class Solve
    {
        static void Main(string[] s)
        {
            while(true)
            {
                Console.WriteLine("=========================Menu_1==========================");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. Print the square triangle (The corner is square at 4 different angles: top-left, top-right, botton-left, botton-right)");
                Console.WriteLine("3. Print isosceles triangle");
                Console.WriteLine("0. Exit Menu_1");
                Console.Write("Enter your choice: ");
                int choice_1 = Convert.ToInt32(Console.ReadLine());
                if(choice_1 == 1)
                {
                    // hinh chu nhat co chieu dai = 6 , chieu rong = 3
                    // nhap chieu dai 
                    Console.Write("Enter Length : ");
                    int Length = Int32.Parse(Console.ReadLine());
                    // nhap chieu rong
                    Console.Write("Enter Width : ");
                    int Width = Int32.Parse(Console.ReadLine());
                    for(int i=0 ; i<Length ; i++)
                    {
                        for(int j=0 ; j<Width ; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                else if(choice_1 == 2)
                {
                    while(true)
                    {
                        Console.WriteLine("------------Menu_2-----------");
                        Console.WriteLine("1. Square triangle at top-left");
                        Console.WriteLine("2. Square triangle at top-right");
                        Console.WriteLine("3. Square triangle at bottom-left");
                        Console.WriteLine("4. Square triangle at bottom-right");
                        Console.WriteLine("0. Exit Menu_2");
                        Console.Write("Enter your choice: ");
                        int choice_2 = Int32.Parse(Console.ReadLine());
                        if(choice_2 == 1)
                        {
                            // nhap canh tam giac vuong (res)
                            Console.Write("Enter Length : ");
                            int res = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Square triangle at top-left");
                            for(int i=res ; i>0 ; i--)
                            {
                                for(int j=0 ; j<i ; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.Write("\n");
                            }
                        }
                        else if(choice_2 == 2)
                        {
                            // nhap canh tam giac vuong (res)
                            Console.Write("Enter Length : ");
                            int res = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Square triangle at top-right");
                            for(int i=0 ; i<res ; i++)
                            {
                                for(int j=0 ; j<res ; j++)
                                {
                                    if(j < i) Console.Write(" ");
                                    else Console.Write("*");
                                }
                                Console.Write("\n");
                            }
                        }
                        else if(choice_2 == 3)
                        {
                            // nhap canh tam giac vuong (res)
                            Console.Write("Enter Length : ");
                            int res = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Square triangle at bottom-left");
                            for(int i=0 ; i<res ; i++)
                            {
                                for(int j=0 ; j<res ; j++)
                                {
                                    if(j > i) Console.Write(" ");
                                    else Console.Write("*");
                                }
                                Console.Write("\n");
                            }
                        }
                        else if(choice_2 == 4)
                        {
                            // nhap canh tam giac vuong (res)
                            Console.Write("Enter Length : ");
                            int res = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Square triangle at bottom-right");
                            for(int i=0 ; i<res ; i++)
                            {
                                for(int j=0 ; j<res ; j++)
                                {
                                    if(i + j >= res - 1) Console.Write("*");
                                    else Console.Write(" ");
                                }
                                Console.Write("\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Exit Menu_2");
                            break;
                        }
                    }
                }
                else if(choice_1 == 3)
                {
                    Console.Write("Enter n : ");
                    int n = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Isosceles triangle");
                    // tam giac can tren n dong
                    for(int i=0 ; i<n ; i++)
                    {
                        for(int j=0 ; j<(i + n) ; j++)
                        {
                            if(i + j >= n - 1)
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
                else if(choice_1 == 0)
                {
                    Console.WriteLine("End Program");
                    break;
                }
            }
        }
    }
}