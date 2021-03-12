using System;

namespace _40_Inheritance_C_
{
    public class Post
    {
        private static int currentPostId;

        // properties
        protected int ID {get; set;}
        protected string Title {get; set;}
        protected string SentByUsername {get; set;}
        public bool IsPublic { get; set; }

        // Default constructor. If derived class does not invoke base-class
        // constructor explicity, the default constructor is call implicitly.
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SentByUsername = "Jaxngad";
        }

        // Instance constructor that has three parameters
        public Post(string title, bool isPublic, string sentbyUsername)
        {
            ID = GetNextID();
            Title = title;
            IsPublic = isPublic;
            SentByUsername = sentbyUsername;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        // Virtual method override of the ToString method that is inherited for System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SentByUsername);
        }
    }
}