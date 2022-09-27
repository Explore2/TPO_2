using TPO_2;
using TPO_2.Interfaces;

namespace TPO_2_TESTS;

public class CalculatorViewMock : ICalculatorView
{
    public string a, b;
    public string errorMessage;
    public double result;

    public void PrintResult(double result)
    {
        this.result = result;
    }

    public void DisplayError(string message)
    {
        errorMessage = message;
    }

    public string GetFirstArgumentAsString()
    {
        return a;
    }

    public string GetSecondArgumentAsString()
    {
        return b;
    }
}