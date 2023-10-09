using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write on oneline and move the Curser to the next line. ");
            Console.WriteLine("This will \n wrap the text ");
            Console.WriteLine("This will print the \" mark ");

            string fName = "Moloko";
            string lName = "Sehata";

            string fullName = fName + " " + lName;
            Console.WriteLine("Full Name is " + fullName);
            Console.WriteLine("Full Name can also be given by " + fName + " " + lName);

            Console.WriteLine("Full Name length is " + fullName.Length);
            Console.WriteLine("Write Full Name in Capital Letters: " + fullName.ToUpper());
            Console.WriteLine("Checks is First Name contains ol " + fName.Contains("ol"));
            Console.WriteLine("Print index 3 of Last Name " + lName[3]);
            Console.WriteLine("The index of a is " + fullName.IndexOf("a"));
            Console.WriteLine(fName.Substring(1,2));

            Console.Read();
        }
    }
}
