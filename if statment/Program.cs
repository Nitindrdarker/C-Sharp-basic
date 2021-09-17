using System;

namespace if_statment
{
    class Program
    {//every this is same as cpp

        static void Main(string[] args)
        {
            bool isMale = false;
            if(isMale)
            {
                Console.WriteLine("yes");
            }
            else{
                Console.WriteLine("Not male");
            }


            
            //switch :- every thing is same as c++
            string dayname; int daynum = 1;
            switch (daynum)
            {
                case 0:
                dayname = "Sunday";
                break;
                case 1:
                dayname = "Monday";
                break;
                default:
                dayname = "Wednesday";
                break;
            
                
            }
            Console.WriteLine(dayname);
        }
        
        

    }
}
