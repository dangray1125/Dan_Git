using System;
namespace _29_Class_Members
{
    public class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary = 20000;

        //member - public field
        public int age;

        //memeber - property - exposes jobTitle safly - properties start with capital letter.
        public string JobTitle 
        { 
            get
            {
                return jobTitle;
            }
             set
             {
                 jobTitle = value;
             } 
        }

        // public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if(isFriend)
            {
                SharingPrivateInfor();
            }
            else
            {
                System.Console.WriteLine("Hi my name is {0}, and my job title is {1}. I am {2} years old",memberName,jobTitle,age);
            }
        }

        private void SharingPrivateInfor()
        {
            System.Console.WriteLine("My salary is {0}",salary);
        }

        //member constructor
        public Members()
        {
                age = 30;
                memberName = "Lucy";
                salary = 60000;
                jobTitle = "Developer";
                System.Console.WriteLine("Object created");
        }

        //member - finalizer - destructor
        ~Members()
        {
            //cleanup statements    ONLY use finalizer when something needs to be cleaned up
            System.Console.WriteLine(("Destruction of Members object"));
        }
        
    }
}