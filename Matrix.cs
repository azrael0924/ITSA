using System;

namespace ConsoleApp1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            string[,]Arr  = new string[100,100];
            string input = Console.ReadLine();
            string[] Sp = input.Split(' ');
            int row = Int32.Parse(Sp[0]);
            int col = Int32.Parse(Sp[1]);
            if (row == 0 || col == 0)
            {
                return;
            }
            for (int i = 0; i < row; i++)
            {
                string[] no = Console.ReadLine().Split(' ');
                for (int j = 0; j < col; j++)
                {
                    Arr[i, j] = no[j];
                }
            }

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (j == row - 1)
                    {
                        Console.Write(Arr[j, i]);
                    }
                    else
                    {
                        Console.Write(Arr[j, i] + " ");
                    }
                   
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
