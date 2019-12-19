using System;

namespace BackToBasic
{
    // Method Overloading
    class Teacher 
    {             
        public int add(int a ,int b) 
        {
            int apples = a + b;
            return apples;
        }

        public int add(int a, int b, int c) 
        {
            int apples = a + b + c;
            return apples;           
        }

        public string controllerMethodOverloading()
        {
            int example = add(1,2);
            int exampleOne = add(1,2,3);
            return "Method 1:" + example + "Method 2:" + exampleOne;
        }
    }

    //binary operators overloading
    class Students 
    {    
        private int boy;
        private int girl;

        public Students(){}

        public Students(int x, int i)
        {
            boy  = x;
            girl = i;
        }

        public string showBoyGirl()
        {
            return "Boy = " + boy + "Girl = " + girl; 
        }

        public Students (Students c) 
        {
            Students temp = new Students();  
            boy  = c.boy;  
            girl = c.girl;            
        }
        public static Students operator -(Students c)  
        {  
            Students temp = new Students();  
            c.boy  = -c.boy;  
            c.girl = -c.girl;  
            return c;  
        }  
    }

    class BinaryOperator 
    {
        public string returnBinaryOverloading() 
        {
            Students e1 = new Students(10,20);
            e1 = -e1;
            string test = e1.showBoyGirl();

            Students e2 = new Students(10,20);
            string test2 =e2.showBoyGirl();

            return "Binary Operator minus overload : " + test + " normal :" + test2;  
        }

    }

    //UnaryOperator Overloading
    class Teacherhelper 
    {        
        private int boy;

        public Teacherhelper(){}

        public Teacherhelper(int x)
        {
            boy  = x;
        }

        public string showBoyGirl()
        {
            return "Boy = " + boy; 
        }

        public Teacherhelper (Teacherhelper c) 
        {
            Teacherhelper temp = new Teacherhelper();  
            boy  = c.boy;            
        }

        public static Teacherhelper operator -(Teacherhelper c)  
        {  
            Teacherhelper temp = new Teacherhelper();  
            c.boy  = -c.boy;  
            return c;  
        }  
    }


    class UnaryOperator 
    {
        public string returnUnaryOperator()
        {
            Teacherhelper e1 = new Teacherhelper(10);
            e1 = -e1;
            string test = e1.showBoyGirl();

            Teacherhelper e2 = new Teacherhelper(10);
            string test2 =e2.showBoyGirl();

            return "Unary Operator minus overload : " + test + " normal :" + test2;  
        }
    }

    //Dynamic Polymorphism [Run time]

        public class Chef 
        {
            public virtual void GetAge()
            {
                Console.WriteLine("30");
            }

            public virtual void GetName()
            {
                Console.WriteLine("Mr Apples");
            }
        }

        public class HeadChef : Chef 
        {
            public override void GetAge()
            {
                Console.WriteLine("hidden");
            }

            public override void GetName()
            {
                Console.WriteLine("Chef Apples");
            }            
        }
}


        
        