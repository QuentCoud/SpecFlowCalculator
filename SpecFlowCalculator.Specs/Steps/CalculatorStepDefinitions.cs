using FluentAssertions;

namespace SpecFlowCalculator.Specs.Steps;
using Xunit;

[Binding]
public sealed class CalculatorStepDefinitions
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;
    
    private readonly Calculator _calculator = new Calculator();
    
    private int _resultInt;
    
    private double _resultDouble;

    public CalculatorStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }
    
    [Given("set number (.*)")]
    public void GivenSetNumber(int number)
    {
        _calculator.numbers.Add(number);
    }

    [When("the numbers are added")]
    public void WhenTheNumbersAreAdded()
    {
        _resultInt = _calculator.Add();
    }

    [When("the numbers are multiplied")]
    public void WhenTheNumbersAreMultiplied()
    {
        _resultInt = _calculator.Multiply();
    }

    [When("the numbers are divided")]
    public void WhenTheNumbersAreDivided()
    {
        _resultDouble = _calculator.Divide();
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int resultInt)
    {
        Assert.Equal(resultInt, resultInt);
    }
    
    [Then("the resultDouble should be (.*)")]
    public void ThenTheResultDoubleShouldBe(double resultDouble)
    {
        Assert.Equal(resultDouble, resultDouble);
    }
}