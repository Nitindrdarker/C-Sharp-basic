using System;

namespace static_key
{
    class Program
    {
        static void Main(string[] args)
        {
           static_use.SayHi("Nitin");//but we will still be able to create the object of this class . to stop this we can name static infront of class declaration
        }
    }
}
