using System;

namespace XAndZeroGameDodo
{
    public class ComputerPlayer : Player
    {
        public override void Move(byte x, byte y)
        {
            if ((x < 3) && (y < 3))
                Table.GameTable[x, y] = 0;
        }

        public override void InitiateMove()
        {
            var random = new Random();
            var isDone = false;

            byte x = 3;
            byte y = 3;

            while (!isDone)
            {
                x = (byte)random.Next(0, 3);
                y = (byte)random.Next(0, 3);

                isDone = EvaluateIsCellIsFree(x, y);
            }

            Move(x, y);
        }
    }
}