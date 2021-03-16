using System;

namespace _42_Class_Interfaces
{
    public interface INotifications
    {
        //members
        void showNotification();
        string getDate();
    }
    public class Notifications : INotifications
    {
        private string sender;
        private string message;
        private string date;

        //default constructor
        public Notifications()
        {
            sender = "Admin";
            message = "your message";
            date = " ";
        }
        public Notifications(string mySender, string myMessage, string myDate)
        {
            this.sender = mySender;
            this.message = myMessage;
            this.date = myDate;
        }
        public void showNotification()
        {
            System.Console.WriteLine("Message {0} - was sent by {1} - at {2}", message , sender , date);
        }
        
        public string getDate()
        {
            return date;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Notifications n1 = new Notifications("Denis", "sup Bro?", "12,06,2020");
           Notifications n2 = new Notifications("Chris","same old same old", "01,01,2021");
           n1.showNotification();
           n2.showNotification();
        }
    }
}
