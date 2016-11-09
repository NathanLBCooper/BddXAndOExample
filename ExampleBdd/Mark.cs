namespace ExampleBdd
{
    public class Mark
    {
        public Mark(int x, int y, Player player)
        {
            X = x;
            Y = y;
            Player = player;
        }

        public int X { get; }
        public int Y { get; }
        public Player Player { get; }
    }
}