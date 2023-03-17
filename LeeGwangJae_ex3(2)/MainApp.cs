using System;

namespace LeeGwangJae_ex3_2_
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 5;

            do
            {
                int j = 0;
                do
                {
                    Console.Write("*");
                    j++;
                }
                while (j < i);
                Console.WriteLine();
                i--;
            }
            while (i > 0);
        }
    }
}
