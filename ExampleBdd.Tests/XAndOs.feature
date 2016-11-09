Feature: XAndOs

Scenario: X wins a simple game of noughts and crosses
	When The board looks like this:
	| . | .. | .. |
	| X | O  | O  |
	| . | X  | O  |
	| . | .  | X  |
	Then Player X has won

Scenario: O wins a simple game of noughts and crosses
	When The board looks like this:
	| . | .. | .. |
	| X | O  | O  |
	| X | O  | .  |
	| . | O  | X  |
	Then Player O has won

Scenario: Tests that reveals how rubbish my implementation is
	When The board looks like this:
	| . | .. | .. |
	| X | O  | X  |
	| . | O  | .  |
	| X | O  | X  |
	Then Player O has won