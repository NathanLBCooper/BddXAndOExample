using FluentAssertions;
using TechTalk.SpecFlow;

namespace ExampleBdd.Tests
{
    [Binding]
    public sealed class StepDefinition
    {
        private readonly GameContext _context;

        public StepDefinition(GameContext context)
        {
            _context = context;
        }

        [When("The board looks like this:")]
        public void When_The_Board_Looks_Like_This(GameBoard board)
        {
            _context.Board = board;
        }

        [Then("Player (.*) has won")]
        public void Then_Player_Has_Won(string player)
        {
            _context.Board.GetWinner().Name.Should().Be(player);
        }
    }
}
