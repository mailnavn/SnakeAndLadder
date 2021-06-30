namespace SnakeAndLadder.DataModel
{
    public class Snake
    {
        public int Head { get; set; }

        public int Tail { get; set; }

        public bool IsValid()
        {
            if ((Head < 1 || Tail < 1) && Head <= Tail)
                return false;

            return true;
        }

    }
}
