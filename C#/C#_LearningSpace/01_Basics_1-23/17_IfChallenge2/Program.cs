/*
Create an application with a score, highscore and a highscorePlayer.
Create a method which has two parameters, one for the score and one for the playerName.
When ever that method is called, it should be checked if the score of the player is higher than the highscore, if so, "New highscore is + " score" 
and in another line "New highscore holder is " + playerName - should be written onto the console, if not "The old highscore of " + highscore + " 
could not be broken and is still held by " + highscorePlayer.
Consider which variables are required globally and which ones locally.
*/

using System;

namespace _17_IfChallenge2
{
    class Program
    {
        static int highScore = 1000;
        static string highScorer = "Ace";
        static void Main(string[] args)
        {
            Console.WriteLine("Lets PLay .... Game Over! ");
            scoreChecker();
            Console.ReadKey();
        }

        static void scoreChecker()
        {
            string scoreString;
            string playerName;
            int score;
            Console.WriteLine("Please enter a score:");
            scoreString = Console.ReadLine();
            bool success = int.TryParse(scoreString, out score);
            if (success == true)
            {   
                if(score>highScore)
                {
                    Console.WriteLine("You now have the new high score enter your name:");
                    playerName = Console.ReadLine();
                    highScorer = playerName;
                    highScore = score;
                    Console.WriteLine("New highscore is {0} \t\t New highscore holder: {1}", highScore, highScorer);
                }
                else
                {
                    Console.WriteLine("YOU could not beat the high score of {0}, held by {1}",highScore, highScorer);
                }
            }
            else
            {
                Console.WriteLine("Error score checking failed.");
            }

        }

    }
}
