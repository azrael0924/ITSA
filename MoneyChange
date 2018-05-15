using System;
using System.CodeDom.Compiler;


namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int count = Int32.Parse(Console.ReadLine());

            if (count < 1 || count > 10)
            {
                return;
            }
           
            for (int i = 0; i < count; i++)
            {
                int fifty = 0;
                int ten = 0;
                int five = 0;
                int one = 0;
                string sum = "";

                string input = Console.ReadLine();
                string[] sp = input.Split(',');

                int pay = Int32.Parse(sp[0]);
                int item = Int32.Parse(sp[1]);
                int quantity = Int32.Parse(sp[2]);



                if (item == 1)
                {
                    pay = pay - (17 * quantity);
                }
                else
                {
                    pay = pay - (25 * quantity);
                }

                if (pay < 1 || pay > 500)
                {
                    break;
                }

                if (pay > 50)
                {
                    while (pay > 50)
                    {
                        pay = pay - 50;
                        fifty = fifty + 1;

                    }
                    if (sum != "")
                    {
                        sum = "," + sum;
                    }
                    sum = "Coin 50:" + fifty;

                }

                if (pay >= 10)
                {
                    while (pay >= 10)
                    {
                        pay = pay - 10;
                        ten = ten + 1;

                    }

                    if (sum != "")
                    {
                        sum = "," + sum;
                    }
                    sum = "Coin 10:" + ten + sum;

                }

                if (pay >= 5)
                {
                    while (pay >= 5)
                    {
                        pay = pay - 5;
                        five = five + 1;

                    }
                    if (sum != "")
                    {
                        sum = "," + sum;
                    }
                    sum = "Coin 5:" + five + sum;

                }

                if (pay >= 1)
                {
                    while (pay >= 1)
                    {
                        pay = pay - 1;
                        one = one + 1;

                    }
                    if (sum != "")
                    {
                        sum = "," + sum;
                    }
                    sum = "Coin 1:" + one + sum;
                }

                Console.WriteLine(sum);
                
            }
            Console.Read();
        }
    }
}
