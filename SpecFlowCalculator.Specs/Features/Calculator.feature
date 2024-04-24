Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator]($projectname$/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given set number 50
	And set number 70
	And set number 12
	When the numbers are added
	Then the result should be 132
	
@mytag
Scenario: Multiply two numbers
	Given set number 5
	And set number 10
	When the numbers are multiplied
	Then the result should be 50
	
@mytag
Scenario: Divide two numbers
	Given set number 20
	And set number 2
	When the numbers are divided
	Then the resultDouble should be 10