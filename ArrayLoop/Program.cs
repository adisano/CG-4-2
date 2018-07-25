using System;

namespace ArrayLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] {1, 1, 2, 3, 5, 8};

            foreach (int myNumbers in myArray)
            {
                Console.WriteLine(myNumbers);
            }
            Console.ReadLine();
        }
    }
}
