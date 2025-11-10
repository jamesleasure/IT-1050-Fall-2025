using System;

namespace InClass4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nCount 0 to 4:");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("\nCountdown 10 to 1:");
            i = 10;
            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            }


            Console.WriteLine("\nSimple Break Statement Example:");
            i = 0;
            while (true)
            {
                if (i < 3)
                {
                    break;
                }
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("\nBreak Statement Example:");
            i = 0;
            while (true)
            {
                if (i > 1000)
                {
                    break;
                }
                else
                {
                    Console.Write('\r');
                }
                Console.Write(i);
                i++;
            }


            Console.WriteLine("\nSimple for loop Example:");
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("\nFor loop example 3-33 (multiples of 3):");
            for (i = 3; i < 34; i += 3)
            {
                Console.WriteLine(i);
            }

            // for (; ; )
            // {
            //     Console.Write("I don't understand the question. ");
            //     break;
            // }

            // i = 1;
            // for (; i < 3; )
            // {
            //      Console.WriteLine(i);
            //     i++;
            // }

            Console.WriteLine("\nKeyword continue:");
            for (i = 0; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            
            
            Console.WriteLine("\nforeach Example:");
            int[] myNum = { 10, 20, 30, 40 };
            foreach (int num in myNum) {
                Console.WriteLine(num);
            }
        }

        
        
    }
}
