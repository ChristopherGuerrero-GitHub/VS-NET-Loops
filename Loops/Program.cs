using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
       
            //for loop
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
            }


            int[] arrInts = new int[] { 3, 5, 6, 23, 95, 45, 32 };
            //foreach loop
            foreach(int item in arrInts)
            {
                Console.WriteLine(item);
            }

            //while loop

            int sentinel = 0;
            while(sentinel < 10)
            {
                Console.WriteLine(sentinel);
                sentinel++;
            }

            //do while
            sentinel = 0;
            do
            {
                Console.WriteLine(sentinel);
                sentinel++;

            } while (sentinel < 10);

        }
    }
}