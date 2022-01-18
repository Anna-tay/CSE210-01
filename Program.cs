using System;
using System.Collections.Generic;

namespace Cse210Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> placeHolder = new List<string>();
            ///To make list 
            for (int i = 0; i < 9; i++)
            {
                placeHolder.Add($"{i}");
            }
            int win = 1;
            DrawBoard(placeHolder);
            while (win == 1)
            {
                PlayerX(placeHolder);
                DrawBoard(placeHolder);
                if (Player1Won(placeHolder ) == "True")
                {
                    Console.WriteLine("Good Job player One! You won");
                    win = 0;
                    break;
                }
                if (NoPlayerWon (placeHolder) == "True"){
                    Console.WriteLine("Its a Draw! Good game!");
                    win = 0;
                    break;
                }
                PlayerO(placeHolder);
                DrawBoard(placeHolder);
                if (Player2Won(placeHolder ) == "True")
                {
                    Console.WriteLine("the O's won");
                    Console.WriteLine("Good Job player Two! You won");
                    win = 0;
                    
                }
            }
            
        }

        // The code for noone winning.
        static string NoPlayerWon (List<string> placeHolder)
        {
            int isTrue = 0;
            int count = -1;
            foreach (string num in placeHolder )
            {
                count = count + 1;
                if (placeHolder[count] == $"{count}" ){
                    isTrue = 1 + isTrue;
                }
                
            } 
            if (isTrue == 0){
                return "True";
            }
            else{
                return "False";
            }
        }

        // to see if player 1 won 
        static string Player1Won(List<string> placeHolder )
        {
            if (placeHolder[0] == "X" && placeHolder[1] == "X" && placeHolder[2] == "X" )
            {
                return "True";
            }
            else if (placeHolder[3] == "X" && placeHolder[4] == "X" && placeHolder[5] == "X" )
            {
                return "True";
            }
            else if (placeHolder[6] == "X" && placeHolder[7] == "X" && placeHolder[8] == "X" )
            {
                return "True";
            }
            else if (placeHolder[0] == "X" && placeHolder[4] == "X" && placeHolder[8] == "X" )
            {
                return "True";
            }
            else if (placeHolder[2] == "X" && placeHolder[4] == "X" && placeHolder[6] == "X" )
            {
                return "True";
            }
            else if (placeHolder[0] == "X" && placeHolder[3] == "X" && placeHolder[6] == "X" )
            {
                return "True";
            }
            else if (placeHolder[1] == "X" && placeHolder[4] == "X" && placeHolder[7] == "X" )
            {
                return "True";
            }
            else if (placeHolder[2] == "X" && placeHolder[5] == "X" && placeHolder[8] == "X" )
            {
                return "True";
            }
            else
            {
                return "False";
            }
            
        }

        // to see if they actuelly won player 2
        static string Player2Won(List<string> placeHolder )
        {
            if (placeHolder[0] == "O" && placeHolder[1] == "O" && placeHolder[2] == "O" )
            {
                return "True";
            }
            else if (placeHolder[3] == "O" && placeHolder[4] == "O" && placeHolder[5] == "O" )
            {
                return "True";
            }
            else if (placeHolder[6] == "O" && placeHolder[7] == "O" && placeHolder[8] == "O" )
            {
                return "True";
            }
            else if (placeHolder[0] == "O" && placeHolder[4] == "O" && placeHolder[8] == "O" )
            {
                return "True";
            }
            else if (placeHolder[2] == "O" && placeHolder[4] == "O" && placeHolder[6] == "O" )
            {
                return "True";
            }
            else if (placeHolder[0] == "O" && placeHolder[3] == "O" && placeHolder[6] == "O" )
            {
                return "True";
            }
            else if (placeHolder[1] == "O" && placeHolder[4] == "O" && placeHolder[7] == "O" )
            {
                return "True";
            }
            else if (placeHolder[2] == "O" && placeHolder[5] == "O" && placeHolder[8] == "O" )
            {
                return "True";
            }
            else
            {
                return "False";
            }
            
        }

        //To have player choose and replace the list
        static void PlayerX(List<string> placeHolder)
        {
            Console.WriteLine("Player 1 choose(0-8): ");
            string playerX = Console.ReadLine();
            int myPlace = int.Parse(playerX);

            placeHolder[myPlace] = "X";
        }
        static void PlayerO(List<string> placeHolder)
        {
            Console.WriteLine("Player 2 choose(0-8): ");
            string playerO = Console.ReadLine();
            int myPlace = int.Parse(playerO);

            placeHolder[myPlace] = "O";
        }

    //draw Board funciton
        static void DrawBoard(List<string> placeHolder)
        {
            Console.WriteLine($"{placeHolder[0]} | {placeHolder[1]} | {placeHolder[2]}  ");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{placeHolder[3]} | {placeHolder[4]} | {placeHolder[5]}  ");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{placeHolder[6]} | {placeHolder[7]} | {placeHolder[8]}  ");
            
        }
    }
}
