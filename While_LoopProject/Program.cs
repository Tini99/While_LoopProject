using System;

namespace While_LoopProject
{
    /*
     Program to print odd numbers between 1 to 20 using while loop
    "Number1" is used as a integer
    */
    class Program
    {
        static void Main(string[] args)
        {
            int Number1;

            Number1 = 1;
            While(Number1 <= 20);
            {
                Console.WriteLine(Number1);
                Number1 = Number1 + 2;
            }

        }
    }
}
