Feature: TennisCuke
	AS A Tennis Umpire
	I WANT a portable digital scoreboard
	SO THAT I can keep track of a game
	AND allow others to see the game status


#@mytag
Scenario: Player Scores first point
	Given I have a game and the Score is ‘0‘– ‘0’ 
	When Player ‘1’ scores
	Then the score should show as 'Player 1 15 - 0 Player 2‘

#@mytag
Scenario: Player One gets score to 15-10
	Given I have a game and the Score is ‘15‘– ‘15’ 
	When Player ‘1’ scores
	Then the score should show as 'Player 1 30 - 15 Player 2‘


#@mytag
Scenario: Player One gets score to 10-15
	Given I have a game and the Score is ‘40‘– ‘40’ 
	When Player ‘2’ scores
	Then the score should show as 'Player 1 40 - 50 Player 2‘


	#@mytag
Scenario: Player One gets score to 40-40
	Given I have a game and the Score is ‘30‘– ‘40’ 
	When Player ‘1’ scores
	Then the score should show as 'Player 1 40 - 40 Player 2‘
