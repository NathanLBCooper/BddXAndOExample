using System.Collections.Generic;
using System.Linq;

namespace ExampleBdd
{
    public class GameBoard
    {
        private readonly IEnumerable<Mark> _marks;

        public GameBoard(IEnumerable<Mark> marks)
        {
            _marks = marks;
        }


        public Player GetWinner()
        {
            // Shrugs. Probably the player with the most marks.
            return _marks.GroupBy(mrk => mrk.Player)
                .OrderByDescending(m => m.Count())
                .Select(m => m.Key)
                .First();
        }
    }
}