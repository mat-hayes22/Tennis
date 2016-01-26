Feature: TennisCuke
	AS A Tennis Umpire
	I WANT a portable digital scoreboard
	SO THAT I can keep track of a game
	AND allow others to see the game status


#@mytag
Scenario: Player Scores first point
	Given I have a game with a score of '0' - '0'
	When Player '1' scores a point
	Then the score should show as Player 1 '15' - '0' Player 2

#@mytag
Scenario: Player Scores second point
	Given I have a game with a score of '0' - '15'
	When Player '1' scores a point
	Then the score should show as Player 1 '15' - '15' Player 2

#@mytag
Scenario: Player with names Scores second point
	Given I have a game between 'Mat' and 'Carl' and the score is '0' - '15'
	When Player '1' scores a point
	Then the score should show as 'Mat' '15' - '15' 'Carl'

# Refactor... Player '1' becomes the name.... next test?