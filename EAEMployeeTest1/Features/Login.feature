Feature: Login
        Check if the Login functionality is working
		as expected with different permutations and
		combinations of data


Background: 
     #Given I Delete employee 'AutoUser' befor I start running test

@skoke @positive
Scenario:  Check Login with correct username and password
    Given I have navigated to the application
	And I see aplication opened
	When I enter UserName and Password and click login
	| UserName              | Password   |
	| pliushkin2197@mail.ru | ghjuhfvbcn |
	Then I click login button
	Then I shold see the registration