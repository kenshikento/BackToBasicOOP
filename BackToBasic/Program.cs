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
            
            string[] arrayCheckList = {"Inheritance","Encapsulation","MethodOverloading","BinaryOperator","UnaryOperator","Dynamic","Abstraction"};

            if(args.Length > 0)
            {   
                foreach (string value in args) 
                {
                    if(Array.Exists(arrayCheckList, element => element != value)) 
                    {   
                        Console.WriteLine("Doesn't match please type in one of these [Inheritance,Encapsulation,MethodOverloading,BinaryOperator,UnaryOperator,Dynamic,Abstraction]");
                    }

                    if(value == "Inheritance") 
                    {   //Inheritance
                        Inheritance test = new Inheritance();
                        Console.WriteLine("Inheritance Result :" + test.controller() + args);
                    }

                    if(value == "Encapsulation") 
                    {
                        // Encapsulation
                        Encapsulation test1 = new Encapsulation();
                        Console.WriteLine("Encapuslation Result :"+ test1.controllerEncap());
                    }

                    // Polymorphism
                    if(value == "MethodOverloading") 
                    {
                        // Method Overloading 
                        Teacher test2 = new Teacher();
                        Console.WriteLine("Encapuslation Result :"+ test2.controllerMethodOverloading());
                    }

                    // Operator overloading 
                    if(value == "BinaryOperator") 
                    {   
                        //Binary Operator
                        BinaryOperator test3 = new BinaryOperator();
                        Console.WriteLine("Binary Result :"+ test3.returnBinaryOverloading());
                    }

                    // Operator overloading 
                    if(value == "UnaryOperator") 
                    {
                        //UnaryOperator
                        UnaryOperator test4 = new UnaryOperator();
                        Console.WriteLine("UnaryOperator Result :"+ test4.returnUnaryOperator());
                    }

                    // Dynamic Polymorphism
                    if(value == "Dynamic") 
                    {
                        // Base
                        Chef test5 = new Chef();
                        Console.WriteLine("Base Class");
                        test5.GetAge();
                        test5.GetName();

                        // Run Time Poly
                        HeadChef test6 = new HeadChef();
                        Console.WriteLine("Run time poly");
                        test6.GetAge();
                        test6.GetName();
                    }

                    // Abstraction
                    if(value == "Abstraction") 
                    {
                        //UnaryOperator
                        Abstraction test7 =  new Abstraction();
                        Console.WriteLine("Abstraction Result :"+ test7.controllerAbstract());
                    }
                }
            }
        }
    }
}
