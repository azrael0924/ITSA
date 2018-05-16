using System;



namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double sum = 0;
            double nosum = 0;
            double Remaining;
            int count = Int32.Parse(Console.ReadLine());
            if (count < 1 || count > 10)
            {
                return;
            }
                
            for (int i = 0; i <= count; i++)
            {
                double input = Int32.Parse(Console.ReadLine());
                if (input > 700)
                {
                    Remaining = input - 700;
                    sum = Remaining * 5.63;
                    nosum = Remaining * 4.50;
                    input = input - Remaining;

                }
                if (input > 500)
                {
                    Remaining = input - 500;
                    sum = sum + Remaining * 4.97;
                    nosum = nosum + Remaining * 4.01;
                    input = input - Remaining;
                }
                if (input > 330)
                {
                    Remaining = input - 330;
                    sum = sum + Remaining * 4.39;
                    nosum = nosum + Remaining * 3.61;
                    input = input - Remaining;
                }
                if (input > 120)
                {
                    Remaining = input - 120;
                    sum = sum + Remaining * 3.02;
                    nosum = nosum + Remaining * 2.68;
                    input = input - Remaining;
                }
                if (input < 121)
                {
                    sum = sum + input * 2.10;
                    nosum = nosum + input * 2.10;
                }

                Console.WriteLine("Summer months:"+sum);
                Console.WriteLine("Non-Summer months:"+nosum);
            }
            
        }
    }
}
