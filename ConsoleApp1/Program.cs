using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[,] arr = new string[5, 5];
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = ((i + j) % 2 == 0) ? (i + j).ToString() : "*";
                }
            }



            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + '\t');
                }

                Console.Write('\n');
            }
        }
    }
}
