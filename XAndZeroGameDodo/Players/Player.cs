namespace XAndZeroGameDodo
{
    public abstract class Player
    {
        public Table Table { get; set; }

        public bool EvaluateIsCellIsFree(byte x, byte y)
        {
            var available = Table.EvaluateIfCellIsFree(x, y);
            if (available)
                Move(x, y);

            return available;
        }

        public abstract void Move(byte x, byte y);

        public abstract void InitiateMove();
    }
}