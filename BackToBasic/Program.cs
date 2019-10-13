using System;

namespace BackToBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {   
                Console.WriteLine("Enter Something in");
            }

            if(args.Length > 0)
            {
                foreach (string value in args) 
                {
                    if(value == "Inheritance") 
                    {
                        Inheritance test = new Inheritance();
                        Console.WriteLine("Inheritance Result :" + test.controller() + args);
                    }
                }
            }
        }
    }
}
