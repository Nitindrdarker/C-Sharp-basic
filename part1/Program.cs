using System;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(coubed(4));
        }
        //static method
        static int coubed(int val)
        {
            return val * val * val;
        }
    }
}
