using System;

namespace LeeGwangJae_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for(int i=5;i>0;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
