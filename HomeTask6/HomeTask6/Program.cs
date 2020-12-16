using System;

namespace HomeTask6
{
    class Program 
    {
        static char[,] Map = new char[15, 15];
        static int turnCount = 0;
        static bool isAlive = true;
        static char currentPosBg = ' ';
       

        static void Main(string[] args)
        {
            Player player1 = new Player('☻', 0, 0);
            Enemy enemy1 = new Enemy('☺', 1, 1);
            Enemy enemy2 = new Enemy('☺', 2, 2);


            GenerateMap();

            Map[1, 1] = player1.Players;
            player1.xPos = 1;
            player1.yPos = 1;

            Map[5, 5] = enemy1.Enemys;
            enemy1.xPos = 5;
            enemy1.yPos = 5;


            RenderMap();
            
            Random rnd = new Random();

            while (isAlive)
            {
                turnCount++;
                bool isInputSuccess;

                do
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    isInputSuccess = true;

                    switch (key)
                    {
                        case ConsoleKey.A:
                            {
                                if (IsPositionAvailable(0, -1))
                                {
                                    SetPlayerToPosition(0, -1);

                                    SetEnemyToPosition();                                  
                                }
                                else
                                {
                                    Console.WriteLine("Position is unavailable");
                                    isInputSuccess = false;
                                }
                                break;
                            }
                        case ConsoleKey.W:
                            {

                                if (IsPositionAvailable(-1, 0))
                                {
                                    SetPlayerToPosition(-1, 0);

                                    SetEnemyToPosition();
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Position is unavailable");
                                    isInputSuccess = false;
                                }
                                break;
                            }
                        case ConsoleKey.D:
                            {

                                if (IsPositionAvailable(0, 1))
                                {
                                     SetPlayerToPosition(0, 1);

                                     SetEnemyToPosition();
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Position is unavailable");
                                    isInputSuccess = false;
                                }
                                break;
                            }
                        case ConsoleKey.S:
                            {

                                if (IsPositionAvailable(1, 0))
                                {
                                      SetPlayerToPosition(1, 0);

                                      SetEnemyToPosition();
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Position is unavailable");
                                    isInputSuccess = false;
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Wrong key, use \"W,A,S,D\"");
                                isInputSuccess = false;
                                break;
                            }
                    }
                }
                while (!isInputSuccess);

                RenderMap();
            }

            bool IsPositionAvailable(int xDelta, int yDelta)
            {
                bool result = true;
                if (player1.xPos + xDelta < 0 || player1.xPos + xDelta >= Map.GetLength(0) ||
                    player1.yPos + yDelta < 0 || player1.yPos + yDelta >= Map.GetLength(1))
                {
                    result = false;
                }
                return result;
            }

            bool EIsPositionAvailable(int XDelta, int YDelta)
            {
                bool result = true;
                if (enemy1.xPos + XDelta < 0 || enemy1.xPos + XDelta >= Map.GetLength(0) ||
                    enemy1.yPos + YDelta < 0 || enemy1.yPos + YDelta >= Map.GetLength(1) )
                {
                    result = false;
                }
                return result;
            }

            void SetPlayerToPosition(int xDelta, int yDelta)
            {
                int newPosX = player1.xPos + xDelta;
                int newPosY = player1.yPos + yDelta;

                Map[player1.xPos, player1.yPos] = currentPosBg;

                currentPosBg = Map[newPosX, newPosY];

                Map[newPosX, newPosY] = player1.Players;

                player1.xPos = newPosX;
                player1.yPos = newPosY;

              
            }

            void SetEnemyToPosition()
            {
                Random rnd = new Random();

                int newPosX = rnd.Next(0,15);
                int newPosY = rnd.Next(0,15);

                Map[enemy1.xPos, enemy1.yPos] = currentPosBg;

                currentPosBg = Map[newPosX, newPosY];

                Map[newPosX, newPosY] = enemy1.Enemys;

                enemy1.xPos = newPosX;
                enemy1.yPos = newPosY;

               
            }

            static void GenerateMap()
            {
                for (int i = 0; i < Map.GetLength(0); i++)
                {
                    for (int k = 0; k < Map.GetLength(1); k++)
                    {
                        Map[i, k] = ' ';
                    }
                }
            }

            static void RenderMap()
            {
                Console.Clear();
                Console.WriteLine($"Turn count: {turnCount}");
                for (int i = 0; i < Map.GetLength(0); i++)
                {
                    Console.WriteLine(new string('-', Map.GetLength(1) * 4 + 1));
                    Console.Write("|");
                    for (int k = 0; k < Map.GetLength(1); k++)
                    {
                        Console.Write(" {0} |", Map[i, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(new string('-', Map.GetLength(1) * 4 + 1));
            }
        }
    }
}
/* int NewPosX = rnd.Next(0, 15);
                int NewPosY = rnd.Next(0, 15);

                Map[enemy2.xPos, enemy2.yPos] = currentPosBg;

                currentPosBg = Map[NewPosX, NewPosY];

                Map[NewPosX, NewPosY] = enemy2.Enemys;

                enemy2.xPos = NewPosX;
                enemy2.yPos = NewPosY;*/

/*
  
&&
                    enemy2.xPos + XDelta < 0 || enemy2.xPos + XDelta >= Map.GetLength(0) ||
                    enemy2.yPos + YDelta < 0 || enemy2.yPos + YDelta >= Map.GetLength(1)
 */