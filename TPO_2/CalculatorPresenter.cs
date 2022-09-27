using TPO_2.Interfaces;

namespace TPO_2;

public class CalculatorPresenter : ICalculatorPresenter
{
    public ICalculator Calculator;
    public ICalculatorView CalculatorView;
    public void OnPlusClicked()
    {
        double a, b;
        if (!Double.TryParse(CalculatorView.GetFirstArgumentAsString(), out a))
        {
            CalculatorView.DisplayError("Cannot parse first argument to double");
            return;
        }
        if(!Double.TryParse(CalculatorView.GetSecondArgumentAsString(), out b))
        {
            CalculatorView.DisplayError("Cannot parse second argument to double");
            return;
        }

        var result = Calculator.Sum(a, b);
        
        CalculatorView.PrintResult(result);
    }

    public void OnMinusClicked()
    {
        double a, b;
        if (!Double.TryParse(CalculatorView.GetFirstArgumentAsString(), out a))
        {
            CalculatorView.DisplayError("Cannot parse first argument to double");
            return;
        }
        if(!Double.TryParse(CalculatorView.GetSecondArgumentAsString(), out b))
        {
            CalculatorView.DisplayError("Cannot parse second argument to double");
            return;
        }

        var result = Calculator.Subtract(a, b);
        
        CalculatorView.PrintResult(result);
    }

    public void OnDivideClicked()
    {
        double a, b;
        if (!Double.TryParse(CalculatorView.GetFirstArgumentAsString(), out a))
        {
            CalculatorView.DisplayError("Cannot parse first argument to double");
            return;
        }
        if(!Double.TryParse(CalculatorView.GetSecondArgumentAsString(), out b))
        {
            CalculatorView.DisplayError("Cannot parse second argument to double");
            return;
        }

        double result = 0;
        try
        {
            result = Calculator.Divide(a, b);
        }
        catch (DivideByZeroException e)
        {
            CalculatorView.DisplayError("Division by zero");
            return;
        }
        
        CalculatorView.PrintResult(result);
    }

    public void OnMultiplyClicked()
    {
        double a, b;
        if (!Double.TryParse(CalculatorView.GetFirstArgumentAsString(), out a))
        {
            CalculatorView.DisplayError("Cannot parse first argument to double");
            return;
        }
        if(!Double.TryParse(CalculatorView.GetSecondArgumentAsString(), out b))
        {
            CalculatorView.DisplayError("Cannot parse second argument to double");
            return;
        }

        var result = Calculator.Multiply(a, b);
        
        CalculatorView.PrintResult(result);
    }
}