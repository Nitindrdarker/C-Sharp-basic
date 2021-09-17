using System;

namespace whole_cshape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");//print the output
            //variables and data types
            /*string yourName = "Nitin";//string
            int myAge;//integer
            myAge = 35;
            Console.WriteLine("My name is " + yourName + " and I am " + myAge + " years old");
            char grade = 'A';//character
            float gpa  = 3.2343f;//least accurate with decimal data type for float use suffix 'f' and for int nothing
            double gpa1 = 3.2343;//in between float and decimal accuracy
            decimal gpa2 = 3.2131m;//most accurate for float use suffix 'm' and for int nothing
            bool isMale = true;
            Console.WriteLine(gpa);
            Console.WriteLine(gpa1);
            Console.WriteLine(gpa2+ " " + gpa1 + " " + gpa +" "+ grade);
            Console.WriteLine(isMale);



            //function on string
            Console.WriteLine(yourName.Length + " is a length of Nitin");//length
            Console.WriteLine(yourName.ToUpper() + " Nitin in upper case");//convert it into uppercase
            Console.WriteLine("If word 'ti' is present in Nitin ? = "  + yourName.Contains("ti"));//is the substring is there or not
            Console.WriteLine(yourName[0] + " is the first character of Nitin");//slicing is allowed in C#
            Console.WriteLine("Index of 'tin' from left is " + yourName.IndexOf("tin"));//find the index fo substring or a character
            Console.WriteLine("Substrign from index 2 to last is " + yourName.Substring(2))// we can always use Substring(2, No. of character) to get the substring between specific indexes
            */
            //we can use math functions using Math.function_name



            //User input
            /*Console.Write("Enter you name:");//wont ceate new line
            string name = Console.ReadLine();//every thing is sotred as string fro user
            Console.WriteLine(name);*/



            //typecasting :- Convert() function
            /*Console.Write("Enter your age:");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(age);*/



            //array
            int [] arr = {1,2,3,4};
            string [] sarr = new String[4];//4 is number fo values this array can hold
            sarr[0] = "nitin";
            sarr[1] = "raj";
            sarr[2] = "singh";
            sarr[3] = "hola";
            Console.WriteLine(sarr[2]);
            Console.WriteLine(arr[2]);








        }
    }
}
