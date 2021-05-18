Feature: Seller can Add Profile Details
In order to test the Profile Feature
	As a seller
	I want to be able to validate that the Profile Deatils are added and visible on the Profile Page of the seller


	@mytag
Scenario: Seller is able to add Language details successfully
	Given I am logged in
	And I am at the profile page
	When I click on Add New under Language tab
	And I enter the details for the new Language
	And I click on Add
	Then I validate the language details are added successfully


	@mytag
Scenario: Seller is able to edit Language details successfully
	Given I am logged in
	And I am at the profile page
	When I click on edit under Language tab
	And I edit the details for the Language
	And I click on Update
	Then I validate the language details are updated successfully


	@mytag
Scenario: Seller is able to delete Language details successfully
	Given I am logged in
	And I am at the profile page
	When I click on delete under Language tab
	Then I validate the language details are deleted successfully
