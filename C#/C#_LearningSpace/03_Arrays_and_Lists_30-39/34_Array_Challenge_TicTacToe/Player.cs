namespace _34_Array_Challenge_TicTacToe
{
    public class Player
    {
        public string name { get; set;}
        public string shape { get; set; }

        public int score {get; set;}

        public Player(string name ,int score)
        {
            this.name = name;
            this.score = score;
        }
    }
}