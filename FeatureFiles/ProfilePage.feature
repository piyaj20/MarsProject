Feature: Seller can Add Profile Details
In order to test the Profile Feature
	As a seller
	I want to be able to validate that the Profile Deatils are added and visible on the Profile Page of the seller


	Scenario: I am able to add description
	Given I am logged in
	And I am at the profile page
	When I click description icon
	And I enter description <description>
	And I click save
	Then Description <description> should be displayed on the profile page
	Examples: 
	| description     |
	| Testing Profile |


	@mytag
Scenario: Seller is able to add Language details successfully
	Given I am logged in
	And I am at the profile page
	When I click on Add New under Language tab
	And I enter the details for the new Language <Language>
	And I click on Add
	Then I validate the language <Language> details are added successfully 
	Examples: 
	| Language |
	| French   |




	@mytag
	Scenario: I am able to add a skill
	Given I am logged in
	And I am at the profile page
	When I click skills tab
	And I click Add New in skills
	And I enter skill <skill>
	And I choose skill level <level>
	And I click Add in skills
	Then Skill <skill> should be displayed on the profile page
	Examples: 
	| skill    | level    |
	| Swimming | Beginner |
	

		@mytag
Scenario: Seller is able to edit Language details successfully
	Given I am logged in
	And I am at the profile page
	When I click on edit under Language tab
	And I edit the details for the Language <Languageupdated>
	And I click on Update
	Then I validate the language <Languageupdated> details are updated successfully
	Examples: 
	| Languageupdated | 
	| German   |

	



