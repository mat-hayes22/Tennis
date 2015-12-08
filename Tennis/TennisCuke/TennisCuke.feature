Feature: TennisCuke
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: First Point in Tennis
	Given I have a tennis game and the score is '0' - '0'
	When a point is scored by player '1'
	Then the score should be 'Player One 15 - 0 Player Two'
