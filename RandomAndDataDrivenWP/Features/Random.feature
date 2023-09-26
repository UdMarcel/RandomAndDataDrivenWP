Feature: Random

A short summary of the feature

@tag1
Scenario Outline: [Random]
	Given I navigate to the wesbite "http://angularjs.realworld.io/#/register"
	And I Click on SignUp
	And I Enter my Username "Hilton"
	And I Enter my email "john"
	And I Enter passowrd "manny"
	When I Click on the Sign up button 
	Then I Should be able to register succesfully 

