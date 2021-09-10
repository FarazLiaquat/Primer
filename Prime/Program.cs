using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int z;
            for (int x = 1; x <= 1000; x++)
            {
                z = 0;
                for (int y = 2; y <= x/2; y++)
                { 
                    if (x % y == 0)
                    {
                        z++;
                         
                        break;
                    }
                }

                if (z == 0 && x != 1)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}

