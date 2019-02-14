Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have a endpoint /endpoint/
	And I have a base url http://mydomain.com/
	When I call get method of the api
	Then the I get the API response in json format
