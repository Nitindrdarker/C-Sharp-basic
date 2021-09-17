using System;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                int num1 = 4, num2 = 0;
                Console.WriteLine(num1 / num2);
                
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("error:-" + e.Message);
            }
            finally{
                Console.WriteLine("finally it will execute no matter what");
            }
            
            
        }
    }
}
