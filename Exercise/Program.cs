using System;

namespace Exercise
{
    class Program
    {
        static void Main()
        {
            string p = "@@";
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine();
                p = p + "@";
            }
        }
    }
}
