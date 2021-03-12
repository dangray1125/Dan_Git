using System;

namespace _34_Array_Challenge_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Player1",0);
            Player player2 = new Player("Player2",0);
            bool playing = true;
            bool noWinner = true;

            System.Console.WriteLine("Welcome to the game of Tic-Tac-Toe!");
            System.Console.WriteLine();

            do
            {
                System.Console.WriteLine("Please decide who will be X and who will be O");
                System.Console.WriteLine("Player 1, what do you choose? X or O");
                string playerSelection = Console.ReadLine().ToUpper();
                player1.shape = PlayerSet(playerSelection);
                player2.shape = OpponentSet(player1);

                System.Console.WriteLine("Player one shape is {0}", player1.shape);
                System.Console.WriteLine("Player two shape is {0}", player2.shape);

                string[,] gameBoard = Gameboard_Init();
                string[] gameSpots = {"0","1","2","3","4","5","6","7","8","9"};
                CallGameBoard(gameBoard);

                while(noWinner)
                {
                    Player1Move(player1, gameSpots,gameBoard);
                    CallGameBoard(gameBoard);
                    noWinner=CheckWinner(gameSpots);
                    if (noWinner == false)
                    {
                        System.Console.WriteLine(player1.shape + " Wins!");
                        player1.score+=1;
                        break;
                    }
                    Player2Move(player2, gameSpots,gameBoard);
                    CallGameBoard(gameBoard);
                    noWinner=CheckWinner(gameSpots);
                    if (noWinner == false)
                    {
                        System.Console.WriteLine(player2.shape + " Wins!");
                        player2.score+=1;
                        break;
                    }
                }

                System.Console.WriteLine("Do you want to play again?");
                playing = CheckPlaying();
            }while(playing);
            System.Console.WriteLine("Final Score: \t{0}: {1} | {2}: {3}",player1.name, player1.score, player2.name, player2.score);
            Console.ReadKey();
        }
    #region Methods
        static string PlayerSet(string playerSelection)
        {
            if(playerSelection == "X")
                return " X ";
            else if (playerSelection== "O")
               return " O ";
            else
                {
                    System.Console.WriteLine("Invalid selection please choose again!");
                    string select = Console.ReadLine();
                    return PlayerSet(select.ToUpper());
                }
        }
        
        static string OpponentSet(Player player1)
        {
            if(player1.shape == " X ")
                return " O ";
            
            else
                return " X ";
        }

        static string[,] Gameboard_Init()
        {
            string[,] gameBoard=
            {
                {"   ","|","   ","|","   "},
                {" 1 ","|"," 2 ","|"," 3 "},
                {"___","|","___","|","___"},
                {"   ","|","   ","|","   "},
                {" 4 ","|"," 5 ","|"," 6 "},
                {"___","|","___","|","___"},
                {"   ","|","   ","|","   "},
                {" 7 ","|"," 8 ","|"," 9 "},
                {"   ","|","   ","|","   "}
            };
            return gameBoard;
        }
        
        static void CallGameBoard(string[,] gameBoard)
        {
            for (int i = 0; i < 9 ; i++)
                {
                    for (int j = 0; j < 5; j++ )
                        Console.Write(gameBoard[i,j]);
                    System.Console.WriteLine();
                }
                System.Console.WriteLine();
        }

        static void Player1Move(Player player, string[] gameSpot, string[,] gameBoard)
        {
            System.Console.WriteLine(player.shape + " Please select a spot");
            string move = Console.ReadLine();
            switch(move)
            {
                case "1":
                {
                    if ((gameSpot[0].Contains(" X "))||(gameSpot[0].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player1Move(player, gameSpot, gameBoard);
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[0] = player.shape;
                        gameBoard[1,0]= move;
                    }
                    break;
                }
                case "2":
                {
                    if ((gameSpot[1].Contains(" X "))||(gameSpot[1].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player1Move(player, gameSpot, gameBoard);
                       
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[1] = player.shape;
                        gameBoard[1,2]= move;
                    }
                    break;
                } 
                case "3":
                {
                    if ((gameSpot[2].Contains(" X "))||(gameSpot[2].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player1Move(player, gameSpot, gameBoard);
                       
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[2] = player.shape;
                        gameBoard[1,4]= move;
                    }
                    break;
                }
                case "4":
                {
                    if ((gameSpot[3].Contains(" X "))||(gameSpot[3].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player1Move(player, gameSpot, gameBoard);
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[3] = player.shape;
                        gameBoard[4,0]= move;
                    }
                    break;
                }
                case "5":
                {
                    if ((gameSpot[4].Contains(" X "))||(gameSpot[4].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player1Move(player, gameSpot, gameBoard);
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[4] = player.shape;
                        gameBoard[4,2]= move;
                    }
                    break;
                }
                case "6":
                {
                    if ((gameSpot[5].Contains(" X "))||(gameSpot[5].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player1Move(player, gameSpot, gameBoard);
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[5] = player.shape;
                        gameBoard[4,4]= move;
                    }
                    break;
                }
                case "7":
                {
                    if ((gameSpot[6].Contains(" X "))||(gameSpot[6].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player1Move(player, gameSpot, gameBoard);
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[6] = player.shape;
                        gameBoard[7,0]= move;
                    }
                    break;
                }
                case "8":
                {
                    if ((gameSpot[7].Contains(" X "))||(gameSpot[7].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player1Move(player, gameSpot, gameBoard); 
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[7] = player.shape;
                        gameBoard[7,2]= move;
                    }
                    break;
                }
                case "9":
                {
                    if ((gameSpot[8].Contains(" X "))||(gameSpot[8].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player1Move(player, gameSpot, gameBoard);
                       
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[8] = player.shape;
                        gameBoard[7,4]= move;
                    }
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid selection please choose another spot");
                    Player1Move(player, gameSpot, gameBoard);
                    break;
                }

            }
        }
        static void Player2Move(Player player, string[] gameSpot, string[,] gameBoard)
        {
            System.Console.WriteLine(player.shape + " Please select a spot");
            string move = Console.ReadLine();
            switch(move)
            {
                case "1":
                {
                    if ((gameSpot[0].Contains(" X "))||(gameSpot[0].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player2Move(player, gameSpot, gameBoard);
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[0] = player.shape;
                        gameBoard[1,0]= move;
                    }
                    break;
                }
                case "2":
                {
                    if ((gameSpot[1].Contains(" X "))||(gameSpot[1].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player2Move(player, gameSpot, gameBoard);
                       
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[1] = player.shape;
                        gameBoard[1,2]= move;
                    }
                    break;
                }
                case "3":
                {
                    if ((gameSpot[2].Contains(" X "))||(gameSpot[2].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player2Move(player, gameSpot, gameBoard);
                       
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[2] = player.shape;
                        gameBoard[1,4]= move;
                    }
                    break;
                }
                case "4":
                {
                    if ((gameSpot[3].Contains(" X "))||(gameSpot[3].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player2Move(player, gameSpot, gameBoard);
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[3] = player.shape;
                        gameBoard[4,0]= move;
                    }
                    break;
                }
                case "5":
                {
                    if ((gameSpot[4].Contains(" X "))||(gameSpot[4].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player2Move(player, gameSpot, gameBoard);
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[4] = player.shape;
                        gameBoard[4,2]= move;
                    }
                    break;
                }
                case "6":
                {
                    if ((gameSpot[5].Contains(" X "))||(gameSpot[5].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player2Move(player, gameSpot, gameBoard);
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[5] = player.shape;
                        gameBoard[4,4]= move;
                    }
                    break;
                }
                case "7":
                {
                    if ((gameSpot[6].Contains(" X "))||(gameSpot[6].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player2Move(player, gameSpot, gameBoard);
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[6] = player.shape;
                        gameBoard[7,0]= move;
                    }
                    break;
                }
                case "8":
                {
                    if ((gameSpot[7].Contains(" X "))||(gameSpot[7].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player2Move(player, gameSpot, gameBoard); 
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[7] = player.shape;
                        gameBoard[7,2]= move;
                    }
                    break;
                }
                case "9":
                {
                    if ((gameSpot[8].Contains(" X "))||(gameSpot[8].Contains(" O ") ))
                    {
                        System.Console.WriteLine("That spot is taken select another spot");
                        Player2Move(player, gameSpot, gameBoard);
                       
                    }
                    else 
                    {
                        move = player.shape;
                        gameSpot[8] = player.shape;
                        gameBoard[7,4]= move;
                    }
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid selection!");
                    Player1Move(player, gameSpot, gameBoard);
                    break;
                }

            }
                
        }
        static bool CheckWinner(string[] gameSpot)
        {
            #region Horizontal win conditions
            if(((gameSpot[0].Contains(" X "))&&(gameSpot[1].Contains(" X "))&&(gameSpot[2].Contains(" X ")))
                || ((gameSpot[0].Contains(" O "))&&(gameSpot[1].Contains(" O "))&&(gameSpot[2].Contains(" O "))))
            {
                return false;
            }
            else if(((gameSpot[3].Contains(" X "))&&(gameSpot[4].Contains(" X "))&&(gameSpot[5].Contains(" X ")))
                || ((gameSpot[3].Contains(" O "))&&(gameSpot[4].Contains(" O "))&&(gameSpot[5].Contains(" O "))))
            {
                return false;
            }
            else if(((gameSpot[6].Contains(" X "))&&(gameSpot[7].Contains(" X "))&&(gameSpot[8].Contains(" X ")))
                || ((gameSpot[6].Contains(" O "))&&(gameSpot[7].Contains(" O "))&&(gameSpot[8].Contains(" O "))))
            {
                return false;
            }
            #endregion
            #region Vertical win conditions
            if(((gameSpot[0].Contains(" X "))&&(gameSpot[3].Contains(" X "))&&(gameSpot[6].Contains(" X ")))
                || ((gameSpot[0].Contains(" O "))&&(gameSpot[3].Contains(" O "))&&(gameSpot[6].Contains(" O "))))
            {
                return false;
            }
            else if(((gameSpot[1].Contains(" X "))&&(gameSpot[4].Contains(" X "))&&(gameSpot[7].Contains(" X ")))
                || ((gameSpot[1].Contains(" O "))&&(gameSpot[4].Contains(" O "))&&(gameSpot[7].Contains(" O "))))
            {
                return false;
            }
            else if(((gameSpot[2].Contains(" X "))&&(gameSpot[5].Contains(" X "))&&(gameSpot[8].Contains(" X ")))
                || ((gameSpot[2].Contains(" O "))&&(gameSpot[5].Contains(" O "))&&(gameSpot[8].Contains(" O "))))
            {
                return false;
            }
            #endregion
            #region Diagonal win conditions
            if(((gameSpot[0].Contains(" X "))&&(gameSpot[4].Contains(" X "))&&(gameSpot[8].Contains(" X ")))
                || ((gameSpot[0].Contains(" O "))&&(gameSpot[4].Contains(" O "))&&(gameSpot[8].Contains(" O "))))
            {
                return false;
            }
            else if(((gameSpot[2].Contains(" X "))&&(gameSpot[4].Contains(" X "))&&(gameSpot[6].Contains(" X ")))
                || ((gameSpot[2].Contains(" O "))&&(gameSpot[4].Contains(" O "))&&(gameSpot[6].Contains(" O "))))
            {
                return false;
            }
            #endregion
            else
                return true;
            
        }
        static bool CheckPlaying()
        {
            string check = Console.ReadLine().ToUpper();
            
            if(check == "YES")
                return true;
            else if (check == "NO")
            {
                System.Console.WriteLine("Okay, Goodbye!");
                return false;
            }
            else
            {
                System.Console.WriteLine("Invalid response try again.");
                return CheckPlaying();
            }
        }
    #endregion
    }   
}
