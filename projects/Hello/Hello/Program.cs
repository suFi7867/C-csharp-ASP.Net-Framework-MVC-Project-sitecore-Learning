using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
     class Program
    {
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

            string name = Console.ReadLine();
            string age = Console.ReadLine();

            Console.WriteLine($"Your name is {name}. and age is {age}");
            // dynamic string

            Console.ReadLine();

        }
    }
}


// namesapace is basically a container in which we can write our code and classes 
