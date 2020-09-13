using System;
using System.Diagnostics;
using System.IO;

namespace LR_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант 27
            Console.WriteLine("Для изменения данных файл input.txt находится в @/LR_Three/LR_Three/bin/Debug/netcoreapp3.1");
            Console.WriteLine("Для просмотра результатов данных файла output.txt находится в @/LR_Three/LR_Three/bin/Debug/netcoreapp3.1");
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            double N, Z = 0, f = 1, t;
            double X, Y;
            t = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            X = Convert.ToDouble(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());

            switch (t)
            {
                case 1:
                    {
                        for (double i = 1; i <= N; i++)
                        {
                            f = f * i;
                            if (i % 2 == 1)
                            {
                                Z = Z + ((Math.Pow(X, i) + Math.Pow(Y, i)) / (f));
                            }
                            else
                            {
                                Z = Z - ((Math.Pow(X, i) + Math.Pow(Y, i)) / (f));
                            }
                        }
                        Console.WriteLine(String.Format("{0:0.00000}", Z));
                        break;
                    }
                case 2:
                    {
                        int K = 1;
                        while (K <= N)
                        {
                            f = f * K;
                            if (K % 2 == 1)
                            {
                                Z = Z + ((Math.Pow(X, K) + Math.Pow(Y, K)) / (f));
                            }
                            else
                            {
                                Z = Z - ((Math.Pow(X, K) + Math.Pow(Y, K)) / (f));
                            }
                            K++;
                        }
                        Console.WriteLine(String.Format("{0:0.00000}", Z));
                        break;
                    }
                case 3:
                    {
                        int K = 1;
                        do
                        {
                            f = f * K;
                            if (K % 2 == 1)
                            {
                                Z = Z + ((Math.Pow(X, K) + Math.Pow(Y, K)) / (f));
                            }
                            else
                            {
                                Z = Z - ((Math.Pow(X, K) + Math.Pow(Y, K)) / (f));
                            }
                            K++;
                        }
                        while (K <= N);
                        Console.WriteLine(String.Format("{0:0.00000}", Z));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка, вы ввели неверные указания в переменной t. Измените значения данной переменной.");
                        break;
                    }
            }
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
