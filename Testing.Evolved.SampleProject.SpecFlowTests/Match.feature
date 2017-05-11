Feature: Match
As a leauge offical
In order to keep track of match result
I want to collect information about match event
Background:
Given a new season 2016/2017 with these teams and players
| Team       | Player |
| The Rovers | James Patrick   |
| The Rovers | Des Watson   |
| The Saints | Carl Franz       |


Scenario: Home team wins
Given The Rovers are the home team
And The Saints are the away team
And James Patrick scores for The Rovers after 30 minutes
And Carl Franz scores for The Saints after 44 minutes
And Des Watson scores for The Rovers after 87 minutes
When the match is finished
Then the match ends 2-1
And The Rovers have 3 points
And The Saints have 0 points


