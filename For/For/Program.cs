using System;

namespace Program
{
    internal class For
    {
        static void Main(string[] args)
        {
            
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Os valores são: " + i);
            }

            int c = 0, c2 = 0;

            while (true)
            {

                Console.WriteLine(c);

                if(c == 10)
                {
                    break;
                }

                c++;
            }

            do
            {

                Console.WriteLine(c2);

                if (c2 == 10)
                {
                    break;
                }

                c2++;

            } while (true);

        }
    }
}