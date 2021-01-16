using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        
        static char[,] playField =
         {
            {'7', '8', '9' },
            {'4', '5', '6' },
            {'1', '2', '3' },
        };

        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;

           

            do
            {
                if (player == 2)
                {
                    EnterXorO(player, input);
                    player = 1;  
                } 
                else if (player == 1)
                {
                    EnterXorO(player, input);
                    player = 2;
                }

                SetField();
                CheckWinning();

                do
                {
                    Console.WriteLine("\nPlayer {0}: Choose youe field!", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please Enter a number!");
                    }

                    if ((input == 1) && (playField[2, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playField[2, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[2, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[0, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[0, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[0, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("This place is already taken! Please try another place.");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);
            } while (true);
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |    ");
            turns++;
        }

        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';

            switch (input)
            {
                case 1:
                    playField[2, 0] = playerSign;
                    break;
                case 2:
                    playField[2, 1] = playerSign;
                    break;
                case 3:
                    playField[2, 2] = playerSign;
                    break;
                case 4:
                    playField[1, 0] = playerSign;
                    break;
                case 5:
                    playField[1, 1] = playerSign;
                    break;
                case 6:
                    playField[1, 2] = playerSign;
                    break;
                case 7:
                    playField[0, 0] = playerSign;
                    break;
                case 8:
                    playField[0, 1] = playerSign;
                    break;
                case 9:
                    playField[0, 2] = playerSign;
                    break;
            }
        }

        public static void CheckWinning()
        {
            if ((playField[0, 0].Equals(playField[0, 1]) && playField[0, 1].Equals(playField[0, 2]) && playField[0, 2].Equals('X'))
             || (playField[1, 0].Equals(playField[1, 1]) && playField[1, 1].Equals(playField[1, 2]) && playField[1, 2].Equals('X'))
             || (playField[2, 0].Equals(playField[2, 1]) && playField[2, 1].Equals(playField[2, 2]) && playField[2, 2].Equals('X'))
             || (playField[0, 0].Equals(playField[1, 0]) && playField[1, 0].Equals(playField[2, 0]) && playField[2, 0].Equals('X'))
             || (playField[0, 1].Equals(playField[1, 1]) && playField[1, 1].Equals(playField[2, 1]) && playField[2, 1].Equals('X'))
             || (playField[0, 2].Equals(playField[1, 2]) && playField[1, 2].Equals(playField[2, 2]) && playField[2, 2].Equals('X'))
             || (playField[0, 0].Equals(playField[1, 1]) && playField[1, 1].Equals(playField[2, 2]) && playField[2, 2].Equals('X'))
             || (playField[0, 2].Equals(playField[1, 1]) && playField[1, 1].Equals(playField[2, 0]) && playField[2, 0].Equals('X')))
            {
                Console.WriteLine("Player 1 is the winner!");
                Console.WriteLine("Please press any key to reset the game");
                Console.ReadKey();
                ResetField();
            }
            else if((playField[0, 0].Equals(playField[0, 1]) && playField[0, 1].Equals(playField[0, 2]) && playField[0, 2].Equals('O'))
             || (playField[1, 0].Equals(playField[1, 1]) && playField[1, 1].Equals(playField[1, 2]) && playField[1, 2].Equals('O'))
             || (playField[2, 0].Equals(playField[2, 1]) && playField[2, 1].Equals(playField[2, 2]) && playField[2, 2].Equals('O'))
             || (playField[0, 0].Equals(playField[1, 0]) && playField[1, 0].Equals(playField[2, 0]) && playField[2, 0].Equals('O'))
             || (playField[0, 1].Equals(playField[1, 1]) && playField[1, 1].Equals(playField[2, 1]) && playField[2, 1].Equals('O'))
             || (playField[0, 2].Equals(playField[1, 2]) && playField[1, 2].Equals(playField[2, 2]) && playField[2, 2].Equals('O'))
             || (playField[0, 0].Equals(playField[1, 1]) && playField[1, 1].Equals(playField[2, 2]) && playField[2, 2].Equals('O'))
             || (playField[0, 2].Equals(playField[1, 1]) && playField[1, 1].Equals(playField[2, 0]) && playField[2, 0].Equals('O')))
            {
                Console.WriteLine("Player 2 is the winner!");
                Console.WriteLine("Please press any key to reset the game");
                Console.ReadKey();
                ResetField();
            }
            else if (turns == 10)
            {
                Console.WriteLine("We have a drawn!");
                Console.WriteLine("Please press any key to reset the game");
                Console.ReadKey();
                ResetField();
            }
        }

        public static void ResetField()
        {
            char[,] playFieldInitial =
            {
            {'7', '8', '9' },
            {'4', '5', '6' },
            {'1', '2', '3' },
            };

            playField = playFieldInitial;
            SetField();
            turns = 0;
        }
    }
}
