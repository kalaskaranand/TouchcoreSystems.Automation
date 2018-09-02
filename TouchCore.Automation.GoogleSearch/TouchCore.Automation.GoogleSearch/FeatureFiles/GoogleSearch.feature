Feature: TouchCoreGoogleSearchResults
		 verify the Google Serach results 
		 for searching KEYWORD TouchCoreSystems

#################################################################################################################################
# Created By : Anand Kalaskar
# Date Created : 01/09/2018  (dd/mm/yyyy)
# Last Modified By :
# Last Modified Date :
# Change History : 
################################################################################################################################

# Google Search scenario
@TouchCoreAutomationTest
@GoogleSearch
Scenario Outline: Google Search - TouchCore
	Given I launch the Application	
	And I Enter "<SearchKey>" details in "txtGoogleSearch" on "GoogleHomePage" screen
	When I Click "btnGoogleSearch" on "GoogleHomePage" Screen
	Then I Validate PageTitle of "GoogleSearchResult" Screen
	And I Verify the "5"th link element of the type "lnkGoogleSearch" Screen
	And I Close the Application
	Examples: 
	| SearchKey			|
	| TouchcoreSystems	|
	| Capgemini			|