using System;

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
    class MultiplicationSign
    {
        static void Main()
        {
            Console.WriteLine("Please type 3 real numbers: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if ((a==0 ||b==0||c==0 ) )
            {
                Console.WriteLine("The product is: 0"); 
            }
            else if (a>0 && b> 0&& c<0)
            {
                Console.WriteLine("The product is: -");
            }
            else if (a>0 && b<0 && c>0)
            {
                Console.WriteLine("The product is: -");
            }
            else if (a<0 &&b>0 && c>0)
            {
                Console.WriteLine("The product is: -");
            }
            else
            {
                Console.WriteLine("The product is: +");
            }
        }
    }

