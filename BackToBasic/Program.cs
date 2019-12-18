using System;

namespace BackToBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation 
            Inheritance test = new Inheritance();
            Console.WriteLine("Inheritance Result :"+ test.controller());   

            // Encapsulation
            Encapsulation test1 = new Encapsulation();
            Console.WriteLine("Encapuslation Result :"+ test1.controllerEncap());

            // Polymorphism  

            // Method Overloading 
            Teacher test2 = new Teacher();
            Console.WriteLine("Encapuslation Result :"+ test2.controllerMethodOverloading());
            
            // Operator overloading 
            binaryOperator test3 = new binaryOperator();
            Console.WriteLine("Encapuslation Result :"+ test3.returnBinaryOverloading());

            UnaryOperator test4 = new UnaryOperator();
            Console.WriteLine("Encapuslation Result :"+ test4.returnUnaryOperator());





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
