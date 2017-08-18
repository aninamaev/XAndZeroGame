using System;

namespace XAndZeroGameDodo
{
    public class UserPlayer : Player
    {
        public override void Move(byte x, byte y)
        {
            Table.GameTable[x, y] = 1;
        }

        public override void InitiateMove()
        {
            byte x = 3;
            byte y = 3;
            var isDone = false;

            while (!isDone)
            {
                var isDoneX = false;
                var isDoneY = false;

                x = 3;
                y = 3;

                while (!isDoneX)
                {
                    try

                    {
                        x = AddCoordinateToShot("x");
                        if (x > 2)
                            throw new Exception();

                        isDoneX = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter an integer between 0 and 2.");
                    }
                }

                while (!isDoneY)
                {
                    try
                    {
                        y = AddCoordinateToShot("y");
                        if (y > 2)
                            throw new Exception();

                        isDoneY = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter an integer between 0 and 2.");
                    }
                }

                isDone = EvaluateIsCellIsFree(x, y);
                if (!isDone)
                {
                    Console.WriteLine("That cell is not available, try another.");
                }
                    
            }
            Move(x, y);
        }

        byte AddCoordinateToShot(string coordinate)
        {
            Console.WriteLine($"{coordinate} coordinate for your shot.");
            return (byte)int.Parse(Console.ReadLine());
        }
    }
}