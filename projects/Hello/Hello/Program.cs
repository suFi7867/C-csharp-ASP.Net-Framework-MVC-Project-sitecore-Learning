using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
     class Program
    {
        static void Greet(string name)
        {
            Console.WriteLine("THIS IS FUNCTION " + name);
        }

        static float Average(int a, int b, int c)
        {
            float sum = a + b + c;
            return sum / 3;
        }

        static float Average(int a, int b)
        {
            float sum = a + b;
            return sum / 3;
        }

        // new learning > we can create same functions name we have 2 functions with same name - Average -   <
        // when we pass 3 args it will take first function with 3 args 
        // when we pass 2 args it will take second function 
 
        // static means this methods belongs to the > Class Program
        /// void use as a type when function returns nothing 

        static void Main(string[] args)
        {
            //int sufi = 21;

            // Console.WriteLine("Sufiyan");
            // Console.WriteLine("Shaikh" + " " + sufi);

            /// Console.ReadLine() will make wait to see console and will not close terminal
            /// 

            /* 
            Data Types in C#
            
            Integer - int sufi = 8 --> take 4 byte 
            Long - long sufi = 888888888888888888888888888888 --> take 8 bytes 
            Floating point number - float that   --> take 4 byte 
            Double - double  sufi; > 8 byte
            Character - char a = "A" / "a"  --> take 2 byte 
            Boolean - bool isGreat = true;  --> take 1 bit
            String - string str =  "SUFIYAN"  --> take 2 byte per character 

            1 byte == 8 bit 

            */


            // string MyInput = Console.ReadLine(); 
            // Console.WriteLine(MyInput); 
            // will take inputs from user 


            /*  int a = 34;
             double c = 34.4D;
             float b = 2.4F;
             bool isGreat = true;
             char d = 'a';
             string e = "sufiyan this is strting";

             Console.WriteLine(a );
             Console.WriteLine(b);
             Console.WriteLine(c);
             Console.WriteLine(isGreat);
             Console.WriteLine(d);
             Console.WriteLine(e)

             ; */


            // TYPE CASTING 

            //1.  Implicit Casting 
            // ex. char to int to long to float to double 
            //int x = 3;
            //double y = x;



            //2.  Explicit Casting 
            //int a = (int) 3.5;
            //double x1 = (double)3.5;

            //int z = 'y';

            //string xx = "334 is string"

            //Console.WriteLine(x);
            //Console.WriteLine(x1);

            //Console.WriteLine("Enter Your name");
            //string inputName = Console.ReadLine();


            //Console.WriteLine("hi" + " " + inputName + " what is your age");
            //string whatsAge = Console.ReadLine();
            //Console.WriteLine("your age is " + " " + whatsAge);

            //Console.WriteLine("after 4 years you will be "  + (Convert.ToInt32(whatsAge) + 4 ));
            //// converting str to int then adding

            //string hello = "sFuiskasbh SSShkasdbj ";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello.ToUpper());

            //string name = Console.ReadLine();
            //string age = Console.ReadLine();

            //Console.WriteLine($"Your name is {name}. and age is {age}");

            //string sufi = "sufiyan is my name got it";

            ////methods 

            //Console.WriteLine(sufi.IndexOf("avs"));
            //// will take first occurence else -1 return

            //Console.WriteLine(sufi.Substring(5));
            //// will spilt from index and return new string
            //// dynamic string


            //string etc = "sufiyan is my \" name got it";
            //// it will print " this in print 
            //// \n will print new line 
            //// \t will give tab kind abig space in between
            ///
            //Console.WriteLine("Enter your age to check you can drive or not");

            //string ageStr = Console.ReadLine();
            //int age = Convert.ToInt32(ageStr);

            //if(age > 18)
            //{
            //    Console.WriteLine("you can drive");
            //}
            //else
            //{
            //    Console.WriteLine("you cant drive");
            //};



            // while loops
            // 
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //// for loop
            //for (int z = 0; z < 5; z++)
            //{
            //    Console.WriteLine(z);
            //}


            /////////////////////////////////////////////////////////////////////

            //// working on functions 

            //Greet("sufiyan");
            //float calcAverage1 = Average(3, 3, 3);
            //float calcAverage2 = Average(2, 6, 8);


            //Console.WriteLine(Average(2, 5)); // working with 2 arg taking second functions logic

            //Console.WriteLine(calcAverage1);
            //Console.WriteLine(calcAverage2);
            //Console.WriteLine($"{calcAverage1} , {calcAverage2}");


            /////////////////////////////////////////////////////////////////////



            // OOPs -  Classes and Objects 
            // Object Oriented Programming 
            // Object-oriented programming (OOP) is a way of writing computer programs
            // that organizes code into objects, which are like building blocks containing data and functions.
            // It emphasizes concepts like inheritance, encapsulation, and polymorphism
            // to make code more modular, flexible, and reusable


            Console.ReadLine();

        }
    }
}


// namesapace is basically a container in which we can write our code and classes 
