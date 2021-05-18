Feature: Seller can login successfully
In order to test the Login Feature
	As a seller
	I want to be able to login successfully using my credentials


	
	@mytag
Scenario: Seller is able to login successfully with his credentials
	Given I am at the login page
	When I click on Sign In
	When I enter valid credentials
	And I click the login button
	Then I should be logged in successfully