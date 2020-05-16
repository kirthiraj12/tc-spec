Feature: User endpoint tests

	So that I can consume correct user metadata
	As a consumer
	I want to be able to query the User Service for information



Scenario: Consumer hits the GET user metadata endpoint and is shown the correct metadata

	Given I am requesting user metadata endpoint
	Then the response should have "OK" as status code
	And each user must include field "id"

