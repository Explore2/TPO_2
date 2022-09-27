using TPO_2.Interfaces;

namespace TPO_2;

public class Calculator : ICalculator
{
    public double Sum(double a, double b) => a + b;

    public double Subtract(double a, double b) => a - b;

    public double Multiply(double a, double b) => a * b;

    public double Divide(double a, double b)
    {
        if (Math.Abs(b) < 10e-8)
        {
            throw new DivideByZeroException();
        }
        return a / b;
    }
}