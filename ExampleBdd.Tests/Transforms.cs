using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace ExampleBdd.Tests
{
    [Binding]
    public class Transforms
    {
        [StepArgumentTransformation]
        public GameBoard GameBoardTransform(Table table)
        {
            var marks = new List<Mark>();
            var players = new List<Player>();

            for (int y = 0; y < table.RowCount; ++y)
            {
                var row = table.Rows[y];
                for (int x = 0; x < row.Count; ++x)
                {
                    if (row[x] == ".")
                    {
                        continue;
                    }
                    var player = TryAddPlayer(players, row[x]);
                    marks.Add(new Mark(x, y, player));
                }
            }

            return new GameBoard(marks);
        }

        private static Player TryAddPlayer(ICollection<Player> players, string name)
        {
            var existing = players.SingleOrDefault(plyr => plyr.Name == name);

            if (existing != null)
            {
                return existing;
            }

            var @new = new Player(name);
            players.Add(@new);
            return @new;
        }
    }
}
