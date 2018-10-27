Feature: New Business Quotes
	This feature supports the generation of new business quotes across multiple products. 


@_NewBusinessQuote
Scenario Outline: Complete the new business quote journey using thousands of different permutations against all products
	Given the user has began the <Product> UI journey for new quote
	When the quote process is repeated multiple times in accordance to the <variations_csv> file
	Then the results are outputted to <results_csv>
	And the results show that every quote expectation passed
Examples: 
| Product		| ProductID		|  variations_csv								| results_csv					| 
| PrimeLet		|	8			| \\data\\input\\PrimeLet_variations.csv		|\\data\\results\\PrimeLet.csv	| 
| Specialists	|	16			| \\data\\input\\Specialists_variations.csv		|\\data\\results\\PrimeLet.csv	| 
| BedRated		|	32			| \\data\\input\\BedRated_variations.csv		|\\data\\results\\PrimeLet.csv	|  
| Unoccupied	|	64			| \\data\\input\\Unoccupied_variations.csv		|\\data\\results\\PrimeLet.csv	|  
| HolidayHomes	|	128			| \\data\\input\\HolidayHomes_variations.csv	|\\data\\results\\PrimeLet.csv	|  
