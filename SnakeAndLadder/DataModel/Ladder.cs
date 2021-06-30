namespace SnakeAndLadder.DataModel
{
    public class Ladder
    {
        public int LowerLevel { get; set; }

        public int HigherLevel { get; set; }

        public bool IsValid()
        {
            if ((LowerLevel < 1 || HigherLevel < 1) && HigherLevel <= LowerLevel)
                return false;

            return true;
        }

    }
}
