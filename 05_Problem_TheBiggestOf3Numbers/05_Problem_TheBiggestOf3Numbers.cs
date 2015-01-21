using System;
//Write a program that finds the biggest of three numbers.
//  a 	    b	    c	    biggest
//  5	    2	    2	    5
//  -2     -2	    1	    1
//  -2      4     	3	    4
//   0	   -2.5 	5	    5
//  -0.1    -0.5	-1.1	-0.1
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Console.WriteLine("Please type 3 numbers: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a>b && b>c)
            {
                Console.WriteLine("A is the bigger number: ----> " + a);
            }
            else if (a<b && b<c)
            {
                Console.WriteLine("C is the bigger number: ----> " +c);
            }
            else if (a==b && b<c)
            {
                Console.WriteLine("C is the bigger number: ----> " + c);
            }
            else if (a>b && b<c)
            {
                Console.WriteLine("C is the bigger number: ----> " + c);
            }
            else
            {
                Console.WriteLine("B is the bigger number: ----> " + b);
            }
        }
    }

