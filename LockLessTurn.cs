using System;
using System.Linq;


namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            int TestCount = Int32.Parse(Console.ReadLine());
            if (TestCount < 1 || TestCount > 10)
            {
                return;
            }
            
            for (int j = 0; j < TestCount; j++)
            {
                int sum = 0;
                string Lock = Console.ReadLine();
                string[] Pw = Lock.Split(' ');
                var Seecode = Pw[0];
                var Decoding = Seecode.ToArray();
                int val = (int) Char.GetNumericValue(Decoding[2]);
                var Correctcode = Pw[1];
                var Decoding1 = Correctcode.ToArray();

                for (int i = 0; i < Decoding.Length; i++)
                {
                    
                    int time = 0;
                    if ((int)Char.GetNumericValue(Decoding[i]) != (int)Char.GetNumericValue(Decoding1[i]))
                    {
                        int Comparison = (int)Char.GetNumericValue(Decoding1[i]) - (int)Char.GetNumericValue(Decoding[i]);
                        int Comparison1 = 10 - (int)Char.GetNumericValue(Decoding[i]);
                        Comparison = Math.Abs(Comparison);
                        Comparison1 = Math.Abs(Comparison1);
                        if (Comparison > Comparison1)
                        {
                            time = Comparison1;
                        }
                        else
                        {
                            time = Comparison;
                        }
                        sum = sum + time;
                    }
                   
                }
                Console.WriteLine(sum);
            }
            Console.Read();
        }
    }
}
