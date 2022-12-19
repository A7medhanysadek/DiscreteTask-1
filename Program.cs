using System;
using System.Diagnostics;

namespace HelloWorldApplication
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            double n1, n2, r, factors = 0;
            // the next code will take the first number from the user and assign the value to the "n1" variable
            Console.WriteLine("enter the first prime number");
            n1 = double.Parse(Console.ReadLine());
            // the next code will take the first number from the user and assign the value to the "n2" variable
            Console.WriteLine("enter the last prime number");
            n2 = double.Parse(Console.ReadLine());
            /* Here the code will do a nested loop to calculate the remainder of the division between the numbers from "n1"(i) to "n2" (entered by the user) and all of the numbers from "z"=1 to the last number "n2" (entered by the user).
            * If the remainder of the division is 0 (this means that "z" is a factor of "i")  the code will add 1 to "factors" variable
            * after the inner loop is finesh the code will check if "factors" value = 2 (check if "i" is prime number or not), if the condition value is true, the code will print "i" value else the code will set "factors" to 0.*/
            for (double i = n1; i > 0 & i <= n2; i++)
            {
                for (double z = 1; z <= n2; z++)
                {
                    if (i % z == 0)
                        factors += 1;
                    else
                        continue;
                }
                if (factors == 2)
                {
                    Console.WriteLine(i);
                }
                else
                factors = 0;
            }


        }
    }
}
