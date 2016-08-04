#Feature: TennisCuke
#	AS A Tennis Umpire
#	I WANT a portable digital scoreboard
#	SO THAT I can keep track of a game
#	AND allow others to see the game status
#
#
#@mytag
#Scenario: Player Scores first point
#	Given I have a game and the Score is ‘0‘– ‘0’ 
#	When Player ‘1’ scores
#	Then the score should show as 'Player 1 15 - 0 Player 2‘
#
#
#Scenario: Player Two wins Game
#	Given I have a game and the Score is ‘15‘– ‘40’ 
#	When Player ‘2’ scores
#	Then the score should show as 'Player 1 15 - 55 Player 2‘
#
#Scenario: Mat Scores a point
#	Given I have a game between 'Mat' and 'Claire' And I have a game and the Score is '15' – '40' 
#	When Player ‘1’ scores
#	Then the score should show as 'Mat' '30' - '40' 'Claire'

#
#Scenario Outline: Specification by example
#	Given I have a game between <P1Name> and <P2Name> and current the Score is <P1Score> – <P2Score> 
#	When Player <WhichPlayer> scores
#	Then <WhichPlayer> will have <Score>
#Examples: 
#		| P1Name | P2Name | P1Score | P2Score | WhichPlayer | Score | 
#		| 'Mat'  | 'Ben'  | 0       | 0       | 1           | 15    | 
#		| 'Mat'   | 'Dave' | 15      | 0       | 1           | 30    |
#		| 'Steve' | 'Ben'  | 30      | 0       | 1           | 40    |
#		| 'Mat'   | 'Ben'  | 40      | 0       | 1           | 55    |
#		| 'Mat'   | 'Ben'  | 40      | 40      | 1           | 50    |
#		| 'Mat'   | 'Ben'  | 40      | 50      | 1           | 40    |
#		| 'Mat'   | 'Ben'  | 50      | 40      | 1           | 55    |
#		| 'John'  | 'Luke' | 40      | 50      | 2           | 55    |
#		| 'John'  | 'Luke' | 40      | 50      | 2           | 55    |
