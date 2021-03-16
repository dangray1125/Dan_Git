using System;
using System.Threading;
namespace _40_Inheritance_C_
{
    public class VideoPost:Post
    {
        //m Members 
        protected bool isPlaying = false;
        protected int currentPosition = 0;
        Timer timer;
        // Properties
        protected string VideoURL { get; set;}
        protected int Length { get; set;}

        public VideoPost() {}
        public VideoPost(string title, string sentbyUsername, string videoURL,int length, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SentByUsername = sentbyUsername;
            this.IsPublic = isPublic;

            this.VideoURL = videoURL;
            this.Length = length;
        }
        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                System.Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }
        private void TimerCallback(Object obj)
        {
            if (currentPosition< Length)
            {
                currentPosition++;
                System.Console.WriteLine("Video is at {0}s",currentPosition);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if (isPlaying)
            { 
                isPlaying=false;
                System.Console.WriteLine("Video stopped at {0}s", currentPosition);
                currentPosition = 0;
                timer.Dispose();
            }
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} {3} seconds - by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SentByUsername);
        }
    }
}