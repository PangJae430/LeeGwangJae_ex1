using System;

namespace LeeGwangJae_ex3_1_
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 1;

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
                i++;
            }
            while (i < 6);
        }
    }
}
