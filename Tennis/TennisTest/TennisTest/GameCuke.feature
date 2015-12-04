

Feature: Tennis Cuke
	In order to record the progress of a tennis match
	As a Tennis Umpire
	I want to be able to automate the tennis rules

Scenario: Player One Scores First Point
	Given I have a new game
	And the Score is ‘0‘ – ‘0’	
	When 'Player One' scores a point	
	Then the score should show as 'Player 1 15 - 0 Player 2'


