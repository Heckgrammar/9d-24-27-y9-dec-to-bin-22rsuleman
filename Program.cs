using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int


            Console.WriteLine("Enter a string");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter a string");
            string string2 = Console.ReadLine();
            string1 = string1.PadLeft(string1.Length + 1);
            Console.WriteLine(string2 + string1);



            //MAIN CHALLENGE: WRITE A PROGRAM TO CONVERT ANY INTEGER TO ITS EQUIVALENT BINARY NUMBER
            //WRITE A CALL TO YOUR NUMBER CONVERSION FUNCTION HERE

            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                num = num / 2;
            }
            
            
        }

        // LET'S USE THE 'STRUCTURED APPROACH' TO PROGRAMMING...A QUICK INTRODUCTION TO SUBBROUTINES(functions and procedures)...a.k.a. 'methods' in C#
        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
      static string numberConversion(int number, int numberbase)
        {
            //CODE GOES HERE
            return result; //REMOVE THE RED LINE!
        }
    }
}
