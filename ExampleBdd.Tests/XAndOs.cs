using FluentAssertions;
using NUnit.Framework;

namespace ExampleBdd.Tests
{
    [TestFixture]
    public class XAndOs
    {
        private readonly Player _playerX = new Player("X");
        private readonly Player _playerO = new Player("O");

        [Test]
        public void X_Wins_A_Simple_Game_Of_Noughts_And_Crosses()
        {
            var board = new GameBoard(new[]
            {
                new Mark(0, 0, _playerX),
                new Mark(0, 1, _playerO),
                new Mark(0, 2, _playerO),
                new Mark(1, 1, _playerX),
                new Mark(1, 2, _playerO),
                new Mark(2, 2, _playerX),
            });

            board.GetWinner().Should().Be(_playerX);
        }

        [Test]
        public void O_Wins_A_Simple_Game_Of_Noughts_And_Crosses()
        {
            var board = new GameBoard(new[]
            {
                new Mark(0, 0, _playerX),
                new Mark(0, 1, _playerO),
                new Mark(0, 2, _playerO),
                new Mark(1, 0, _playerX),
                new Mark(1, 1, _playerO),
                new Mark(2, 1, _playerO),
                new Mark(2, 2, _playerX),
            });

            board.GetWinner().Should().Be(_playerO);
        }

        [Test]
        public void Test_That_Reveals_How_Rubbish_My_Implementation_Is()
        {
            var board = new GameBoard(new[]
            {
                new Mark(0, 0, _playerX),
                new Mark(0, 1, _playerO),
                new Mark(0, 2, _playerX),
                new Mark(1, 0, _playerO),
                new Mark(2, 0, _playerX),
                new Mark(2, 1, _playerO),
                new Mark(2, 2, _playerX),
            });

            board.GetWinner().Should().Be(_playerO);
        }
    }
}
