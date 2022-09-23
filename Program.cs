// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

namespace Truth_Table
{
    class Program
    {

        static void Main(String[] args)
        {
            string A = "true";
            string B = "false";
            bool boolA = true;
            bool boolB = false;
            
            Console.WriteLine("Please enter true or false.");
            A = Console.ReadLine();
            boolA = System.Convert.ToBoolean(A);
            Console.WriteLine("Please enter true or false again.");
            B = Console.ReadLine();
            boolB = System.Convert.ToBoolean(B);

            if (boolA == true && boolB == true) {
                Console.WriteLine("A && B = T");
            }else if(boolA == true && boolB == false) {
                Console.WriteLine("A && B = F");
            }else if (boolA == false && boolB == true) {
                Console.WriteLine("A & B = F");
            }else if (boolA == false && boolB == false) {
                Console.WriteLine("A & B = F");
            }
            
            if (boolA == true || boolB == true) {
                Console.WriteLine("A || B = T");
            } else if (boolA == true || boolB == false) {
                Console.WriteLine("A || B = T");
            } else if (boolA == false || boolB == true) {
                Console.WriteLine("A || B = T");
            } else if (boolA == false || boolB == false) {
                Console.WriteLine("A || B = F");
            }
            
            if ((boolA == true && boolB == true) && (boolA == true || boolB == true)) {
                Console.WriteLine("(A && B) && (A || B) = T");
            } else if ((boolA == true && boolB == false) && (boolA == true || boolB == true)) {
                Console.WriteLine("(A && B) && (A || B) = F");
            } else if ((boolA == false && boolB == true) && (boolA == true || boolB == true)) {
                Console.WriteLine("(A && B) && (A || B) = F");
            } else if ((boolA == false && boolB == false) && (boolA == false || boolB == false)) {
                Console.WriteLine("(A && B) && (A || B) = F");
            }

            if ((boolA == true && boolB == true) || (boolA == true || boolB == true)) {
                Console.WriteLine("(A && B) || (A || B) = T");
            } else if ((boolA == true && boolB == false) || (boolA == true || boolB == true)) {
                Console.WriteLine("(A && B) || (A || B) = T");
            } else if ((boolA == false && boolB == true) || (boolA == true || boolB == true)) {
                Console.WriteLine("(A && B) || (A || B) = T");
            } else if ((boolA == false && boolB == false) || (boolA == false || boolB == false)) {
                Console.WriteLine("(A && B) || (A || B) = F");
            }
        }
    }

}