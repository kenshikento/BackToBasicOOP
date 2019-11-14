using System;

namespace BackToBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Inheritance test = new Inheritance();
            Console.WriteLine("Inheritance Result :"+ test.controller());

            Encapsulation test1 = new Encapsulation();
            Console.WriteLine("Encapuslation Result :"+ test1.controllerEncap());

            // Polymorphism 
            
            // Abstraction 



            /*if(args.Length == 0)
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
            }*/
        }
    }
}
