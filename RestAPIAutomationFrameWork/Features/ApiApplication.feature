Feature: Test Api 

@mytag
Scenario: Test API endpoint
	Given I have a endpoint /api/v2/pokemon/ditto
	When I call get method of api
	Then I get API response in json format

Scenario Outline: Get User information using userid
	Given I have a endpoint /userid/
	When I call get method to get user information using <userid>
	Then I will get user information 

Examples: User Info
|	userid
|	useri0001


