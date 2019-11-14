using System;

namespace BackToBasic
{
    class ParentPrivate 
    {
        private string parentName,parentLocation;
        private int parentAge;

        public void SetParentName()
        {
            parentName = "Mr Apple Bob";
        }

        public void SetParentLocation()
        {
            parentLocation = "location";
        }
        
        public void SetParentAge(int i)
        {
            parentAge = i;
        }

        public string getInfoEncap() 
        {
            return "Values that can potentially be readable :" + parentName + " ," + parentLocation + " or set:" + parentAge;
        }
    }

    /** Controller Class */
    class Encapsulation
    {
        ParentPrivate d = new ParentPrivate();
            
        public string controllerEncap()
        {
            ParentPrivate parent = new ParentPrivate(); 
            
            parent.SetParentAge(100);
            parent.SetParentName();
            parent.SetParentLocation();
    
            return parent.getInfoEncap();
        }

    }    
}
