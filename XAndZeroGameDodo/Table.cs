using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAndZeroGameDodo
{
    public class Table
    {
        public byte[,] GameTable { get; set; } = new byte[3, 3];

        public Table()
        {
            for (var i = 0; i < 3; i++)
                for (var j = 0; j < 3; j++)
                {
                    GameTable[i, j] = 4;
                }
        }

        public bool EvaluateIfCellIsFree(byte x, byte y)
        {
            return GameTable[x, y] == 4;
        }

        public void PrintCurrentGameTable()
        {
            Console.WriteLine("---------------------------");
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Console.Write(GameTable[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine();
        }
    }
}
