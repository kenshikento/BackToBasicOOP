using System;
using System.Text;

namespace BackToBasic
{
    class Tutor 
    {
        private string name;
        private string subject;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public string Subject 
        {
            get { return subject; }
            set { subject = value; }
        }

        public string getInfoTutor() 
        {
            return "Name:" + Name + "Subject" + Subject; 
        }
    }

    /** Controller Class */
    class Abstraction
    {      
        public string controllerAbstract()
        {
            Tutor tutor = new Tutor(); 
            
            tutor.Name = "name";
            tutor.Subject = "english";
    
            return tutor.getInfoTutor();
        }
    }    
}
