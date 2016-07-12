using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        /// <summary>
        /// Exercise 2
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Create a new string containing your name
            string myName = "TopQ";
            //Print your name
            Console.WriteLine(myName);
            //Print hello and your name "Hello myname"
            Console.WriteLine("Hello " + myName);
            //Add "!" to your name
            myName = myName + "!";
            //Another way:
            //myName += "!";
            //Print the size of the string you got
            Console.WriteLine(myName.Count());
        }

        static string hello(string yourName)
        {
            return "Hello Mr/Mrs " + yourName;
        }
    }
}
