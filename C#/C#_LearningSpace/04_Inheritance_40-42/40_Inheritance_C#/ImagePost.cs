using System;
namespace _40_Inheritance_C_
{
    // for inheritance you use the colon and the name of the class you want to inherit from ex:    ImagePost:Post
    public class ImagePost:Post  
    {
        protected string ImageURL { get; set;}

        public ImagePost() { }
        public ImagePost(string title, string sentbyUsername, string imageURL, bool isPublic)
        {
            // The following properties and the GetNextID method are inherited from Post.
            this.ID = GetNextID();
            this.Title = title;
            this.SentByUsername = sentbyUsername;
            this.IsPublic = isPublic;
        
            // Property ImageURL is member of ImagePost, but not Post
            this.ImageURL = imageURL;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageURL, this.SentByUsername);
        }
        
    }
}