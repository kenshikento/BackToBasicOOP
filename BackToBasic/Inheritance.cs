using System;

namespace BackToBasic
{
    /** Base Class */
    class Parent 
    {
        public void seteyecolour() 
        {
            eyecolour = "black";
        }

        public void setHeight(int h) 
        {
            height = h;
        }

        public void setEducation(string e) 
        {
            education = e;
        }

        protected int height;
        protected string eyecolour, education;
    }

    /*Inheritanted Class */
    class Child: Parent 
    {
        public void seteyecolour(string c)
        {
            eyecolour = c;
        }
        public string getInfo() 
        {
            return "Parents inherited info :" + education + " ," + height + " Child info :" + eyecolour;
        }
    }

    class Inheritance
    {
        public string controller()
        {
            Child childStats = new Child(); 
            
            childStats.setHeight(5);
            childStats.setEducation("Maths");
            childStats.seteyecolour("Blue");

            return childStats.getInfo();
        }
    }
}
