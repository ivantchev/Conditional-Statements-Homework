﻿using System;
//write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
//Example 1:

//program	user
//Please choose a type:	
//1 --> int	
//2 --> double	3
//3 --> string	
//Please enter a string:	hello
//hello*	
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.WriteLine("Please type an input, which can be:\n1 --> Integer\n2 --> Double\n3 --> String");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Please enter a Integer:");
                    int integer = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}", ++integer);
                    break;
                case "2":
                    Console.WriteLine("Please enter a Double:");
                    double floating = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}", ++floating);
                    break;
                case "3":
                    Console.WriteLine("Please enter a String:");
                    string str = Console.ReadLine();
                    Console.WriteLine("Result: {0}*", str);
                    break;
                default: Console.WriteLine("Input must be 1, 2 or 3");
                    break;
            }
        }
    }

