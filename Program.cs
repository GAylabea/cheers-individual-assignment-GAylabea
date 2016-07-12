using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // variables section
            String prompt = "> ";
            String cheer_prefix = "Give me a";

            Console.WriteLine("What's your name?");
            Console.Write(prompt);
            String user_name = Console.ReadLine(); //read from terminal to save a variable
            
            for(int i = 0; i < user_name.Length; i++) {
                Console.WriteLine(cheer_prefix + ".." + user_name[i]);    
            }

            // user_naem.ToUpper() is turing the user's name to uppercase.
            // ToUpper() is functionality specific to Strings
            // ToUpper) accepts no arguments

            Console.WriteLine(user_name.ToUpper() + " is..GRAND!"); 
        }
    }
}
