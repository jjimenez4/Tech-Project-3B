using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Project_3B
{
  class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[25]; //created array of 25
            int i;
            
            Console.WriteLine("Array is as follows:");
            Console.WriteLine("_________________________");
            Console.WriteLine("Elements of Array:");

            try
            {
                for (i=0; i<=25; i++)
                {
                    Console.WriteLine("Element - {0}", i); //shows elements of array 
                }
            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey(true);

            }//end try

            catch //incase of errors
            {
                Console.WriteLine("Error has occured, please close application and try again");
                Console.ReadKey(true);
            }//end catch
        }
    }
}
