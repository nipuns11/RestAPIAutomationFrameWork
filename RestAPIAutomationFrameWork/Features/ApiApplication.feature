Feature:http bin api's

@mytag
Scenario: Test API 
	Given I have a endpoint /get
	When I call get method of api
	Then I get API response in json format

Scenario Outline: Get bytes information using n
	Given I have a endpoint /bytes/
	When I call get method to get user information using <n>
	Then I will get user information 

Examples: bytes info
| n |
| 1 |	


