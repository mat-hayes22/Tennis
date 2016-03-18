Feature: TennisCuke
	AS A Tennis Umpire
	I WANT a portable digital scoreboard
	SO THAT I can keep track of a game
	AND allow others to see the game status


@mytag
Scenario: Mat Scores a point
	Given I have a game between 'Mat' and 'Claire' And I have a game and the Score is '15' – '40' 
	When Player ‘1’ scores
	Then the score should show as 'Mat' '30' - '40' 'Claire'

@mytag
Scenario: Giles Wins a game
	Given I have a game between 'Dewy' and 'Giles' And I have a game and the Score is '0' – '40' 
	When Player ‘2’ scores
	Then the score should show as 'Dewy' '0' - '55' 'Giles'  