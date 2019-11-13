/*Solution based on the char array 10 on 10 which represents field. 
User use arrow keys to move. Also user can press q to exit the program.
There are 10 bombs on field, when user steps on bomb it's health randomly decreases on 1-10 health. Also KABOOM message displays.
When user step on bomb this bomb no more exist, if knight will step on this bomb again nothing will happen.
Game ends if less or equal to zero health left, if he reaches princess, or if he selects to quick with q.
K - Knight
P - Princess
O - ordinary cell
Have fun!*/

using System;

namespace Module5
{
    class Program
    {

        public static int lifePoints = 10;  //Assigning initial health.
        static readonly Random randomValue = new Random();      //Used for generation of the random numbers.
        public static ConsoleKey key;                           //User for processing input from the user.
        static void Main()
        {
            int[,] bombsDestination = BombsPlanting();          //Array int[2,10] which stores destinations of the bombs.
            int playerPositionX = 9;                            
            int playerPositionY = 9;
            while (lifePoints >0 & (playerPositionX != 0 || playerPositionY!= 0))   //Cycle will run until user reaches princess or health will become <=0
            {
                Console.WriteLine($"Player Hitpoints: {lifePoints}");               //On each iteration health and updated field displayed.
                PrintingField(playerPositionX, playerPositionY);
                key = Console.ReadKey(true).Key;                                    //Waiting for the next move from the user.
                Console.Clear();
                if (key == ConsoleKey.UpArrow)                                      //If user will go up horizontal value will decreased by 1
                {
                    playerPositionX--;
                    if (BorderCheck(playerPositionX, playerPositionY))              //Checking that user not leave borders.
                    {
                        for (int i = 0; i < bombsDestination.GetLength(1); i++)     //If user in the borders raised check that user on the bomb.
                        {
                            if (playerPositionX == bombsDestination[0, i] && playerPositionY == bombsDestination[1, i])
                            {
                                bombsDestination[0, i] = -1;                         //When user step on the bomb KABOOM messages displayed, and this bomb
                                bombsDestination[1, i] = -1;                         //Blows, and no more exist. If user will step on this field again
                                lifePoints -= randomValue.Next(1, 11);               //Nothing will happen
                                Console.WriteLine("KABOOM"); 
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Player can't get out of borders!!!");    //If position after move outside the border error will appear.
                        playerPositionX++;
                        continue;
                    }
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    playerPositionX++;
                    if (BorderCheck(playerPositionX, playerPositionY))
                    {
                        for (int i = 0; i < bombsDestination.GetLength(1); i++)
                        {
                            if (playerPositionX == bombsDestination[0, i] && playerPositionY == bombsDestination[1, i])
                            {
                                bombsDestination[0, i] = -1;
                                bombsDestination[1, i] = -1;
                                lifePoints -= randomValue.Next(1, 11);
                                Console.WriteLine("KABOOM!!!");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Player can't get out of borders!!!");
                        playerPositionX--;
                        continue;
                    }
                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    playerPositionY--;
                    if (BorderCheck(playerPositionX, playerPositionY))
                    {
                        for (int i = 0; i < bombsDestination.GetLength(1); i++)
                        {
                            if (playerPositionX == bombsDestination[0, i] && playerPositionY == bombsDestination[1, i])
                            {
                                bombsDestination[0, i] = -1;
                                bombsDestination[1, i] = -1;
                                lifePoints -= randomValue.Next(1, 11);
                                Console.WriteLine("KABOOM");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Player can't get out of borders!!!");
                        playerPositionY++;
                        continue;
                    }
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    playerPositionY++;
                    if (BorderCheck(playerPositionX, playerPositionY))
                    {
                        for (int i = 0; i < bombsDestination.GetLength(1); i++)
                        {
                            if (playerPositionX == bombsDestination[0, i] && playerPositionY == bombsDestination[1, i])
                            {
                                bombsDestination[0, i] = -1;
                                bombsDestination[1, i] = -1;
                                lifePoints -= randomValue.Next(1, 11);
                                Console.WriteLine("KABOOM");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Player can't get out of borders!!!");
                        playerPositionY--;
                        continue;
                    }
                }
                else if (key == ConsoleKey.Q)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You've pressed wrong key");
                    continue;
                }
                
            }
            //After exiting the cycle check raised. If user save princess - gratz message will display. If health <0 - Knight failed.
            Console.Clear();
            if (playerPositionX == 0 && playerPositionY == 0)
                Console.WriteLine("You save the princess!");
            else if (lifePoints <= 0)
                Console.WriteLine("Brave hero explodes at one of the bombs....");
            Console.WriteLine("Wanna play again? Just type Y and Enter to play again. Any other key and Enter to exit"); //Asking for another attemp
            if (Console.ReadLine()=="Y")
            {
                Console.Clear();
                lifePoints = 10;
                Main();
            }

        }

        public static void PrintingField(int positionX, int positionY)  //Method called after each move of the user.
        {
            
            char[,] field = new char[10, 10];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = 'O';
                }
            }
            field[positionX, positionY] = 'K';
            field[0, 0] = 'P';
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write("{0} ", field[i, j]);
                }
                Console.WriteLine(" ");
            }
        }
        public static int[,] BombsPlanting()                        //Method called once in the beginning of the game
        {
            int[,] bombs = new int[2, 10];
            for (int i = 0; i < bombs.GetLength(0); i++)
            {
                for (int j = 0; j < bombs.GetLength(1); j++)
                {
                    bombs[i, j] = (randomValue.Next(1, 11));
                }
            }
            return bombs;
        }

        public static bool BorderCheck(int x, int y)               //Method called after each move to check that knight isn't leave the border.
        {
            if (x < 0 || x > 9 || y < 0 || y > 9)
                return false;
            else return true;

        }
    }
}