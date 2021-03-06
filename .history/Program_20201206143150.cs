﻿using System;
// namespace is used to organize your code, and it is a container for classes and other namespaces
namespace practise
{
    //class is a container for data and methods, which brings functionaility to our program.
    class Program
    {
        //Main is a method 

        //highlight lines, then command key + / to comment out multiple lines
    
        static void Main(string[] args)
        {   
            //variables are containers for storing values 
            //int is the type, numRings is the variable name, 5 is the value of numRings
            //if you assign a new value to an existing variable, it will overwrite previous value
            //The const keyword wont let us overwrite existing values
            //const int numRings=5; this will throw an error when the line below it is executed 
            int numRings = 5;
            numRings=3;
            string name = "kobe";
            if(numRings >= 5 && name == "kobe")
            {
                Console.WriteLine($"Welcome to the party {name}, congratulation on your {numRings} championships!");
                
            }
            else if (numRings >2)
            {
                Console.WriteLine($"Decenet...but {numRings} rings arnt enough");
            }
            else
            {
                Console.WriteLine("go win more rings");
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(5);
            }

            Random rand = new Random();

            string firstName = "John";
            string lastName = "Wilber";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            //to delcare more than 1 variable of the same type, use a comma seperated list
            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);

            //type casting - This is when you assign a value of one date type to another data type
            //implicit casting (auto) converting a smaller type to a larger type
            //char > int > long > float > double
            //explicit casting- This is when you convert a larger type to a smaller type
            //double > float > long > int > char

            //had to comment the next 4 lines to make the code below that actually work uncommit out 
            //these 4 below lines to test then follow this up by commenting out 4 lines below that

            // int myInt = 9;
            // double myDouble = myInt;//auto casting int to double
            // Console.WriteLine(myInt);
            // Console.WriteLine(myDouble);

            //explicit casting must be done manually by placing the type in parentheses in front of the value
            // double myDouble = 9.78;
            // int myInt = (int) myDouble;
            // Console.WriteLine(myDouble);//will output 9.78
            // Console.WriteLine(myInt);//will output 9

            //type conversion methods
            //using built in methods to convert data types
            //Convert.ToBoolean
            //Convert.ToDouble
            //Convert.ToString
            //Convert.ToInt32(int)
            //Convert.ToInt64(long)

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));//prints 10
            Console.WriteLine(Convert.ToDouble(myInt));//prints 10
            Console.WriteLine(Convert.ToInt32(myDouble));//prints 5
            Console.WriteLine(Convert.ToString(myBool));//prints true

            int sum1 = 100 + 50;
            int sum2 = sum1 + 250;
            int sum3 = sum2 + sum2;
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            int e = 10;
            e += 5;
            Console.WriteLine(e);

            // || this returns true if one of the statements is true, think of it as "or"

            //A string in c# is an object,which contains properties and methods that can perform certain operations on strings
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the string is" + " " + txt.Length);

            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());

            string 
        }
    }
}
