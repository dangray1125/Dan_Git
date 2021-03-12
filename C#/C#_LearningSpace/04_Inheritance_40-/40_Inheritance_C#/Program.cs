using System;

namespace _40_Inheritance_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the Bday wishes!", true, "Jaxngad");
            System.Console.WriteLine(post1.ToString());
            System.Console.WriteLine();

            ImagePost imagePost1 = new ImagePost("Checkoout my new shoes!", "Jaxngad", "https://fakeLink.com/shoes", true);
            System.Console.WriteLine(imagePost1.ToString());
            System.Console.WriteLine();
            

            VideoPost videoPost1 = new VideoPost("Check out this clip getting slithery in the snake", "Jaxngad", "https://fakeLink.com/snakeVideo", 22, true);
            System.Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            System.Console.WriteLine("Press any key to stop the video.");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadKey();

        }
    }
}
