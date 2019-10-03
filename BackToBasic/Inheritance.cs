
namespace BackToBasic
{
    /** Base Class */
    class Shape 
    {
        public void setWidth(int w) 
        {
            width = w;
        }

        public void setHeight(int h) 
        {
            height = h;
        }

        protected int width,height;
    }

    /*Inheritanted Class */
    class Rectangle: Shape 
    {
        public int getArea() 
        {
            return (width * height);
        }
    }
    class Inheritance
    {
        public int controller()
        {
            Rectangle rect = new Rectangle(); 
            
            rect.setHeight(5);
            rect.setWidth(7);

            return rect.getArea();
        }
    }
}