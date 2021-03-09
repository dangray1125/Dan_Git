using System;

namespace _32_Foreach_SwitchStatment_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Explanation  
            // Create an application that takes 2 input values.

            // Any input value (1st input)

            // Asks the data type of the input value. (2nd input)

            // It will print to the console the options like below to take input for the 2nd input value:

            // Press 1 for String

            // Press 2 for integer

            // Press 3 for Boolean

            // If the input value for the 2nd input is 1 then the application should check that if the entered 1st input is a valid string or not. Hereby we even want to check, if it is a complete alphabetic entry (so no numbers accepted)

            // If the input value for the 2nd input is 2 then the application should check if the entered 1st input is a valid integer or not.

            // Based on the input the 1st value and the selection of data type using the 2nd input, the application should return whether the entered 1st value is of data type selected by the user or not.

            // Please make sure to use a switch statement. To check the valid string you can write your custom logic.
            #endregion
            int num;
            
            System.Console.WriteLine("Enter any input value.");
            string input= Console.ReadLine();

            string[] dataTypes ={ "1. String", "2. Integer", "3. Boolean"};
            System.Console.WriteLine("Please select the data type to check for validity");
            foreach( string type in dataTypes)
            {
                System.Console.WriteLine(type);
            }
            string dataChecker = Console.ReadLine();
            switch(dataChecker)
            {
                case "1":
                    if( Alphabetic(input)==true)
                    {
                        System.Console.WriteLine("You have entered {0},",input);
                        System.Console.WriteLine("It is a valid String");
                    }
                    else
                    {
                        System.Console.WriteLine("You have entered {0},",input);
                        System.Console.WriteLine("It is not a valid String");
                    }
                    break;
                case "2":
                    if(int.TryParse(input,out num))
                    {
                        System.Console.WriteLine("You have entered {0},",input);
                        System.Console.WriteLine("It is a valid Integer");
                    }
                    else
                    {
                        System.Console.WriteLine("You have entered {0},",input);
                        System.Console.WriteLine("It is not a valid Integer");
                    }
                    break;
                case "3":
                    string newInput = input.ToLower();
                    if((newInput == "false") || (newInput == "true" ))
                        {
                            System.Console.WriteLine("You have entered {0},",input);
                            System.Console.WriteLine("It is a valid boolean");
                        }
                    else
                        {
                            System.Console.WriteLine("You have entered {0},",input);
                            System.Console.WriteLine("It is not a valid Boolean");
                        }
                    break;
                default:
                        System.Console.WriteLine("invalid Choice please run program again");
                        break;
                

            }
            Console.ReadLine();
        }
        static bool Alphabetic(string value)
        {
            foreach(char c in value)
            {
                if(!char.IsLetter(c))
                    return false;
            }
            return true;
        
        }
    }
}
