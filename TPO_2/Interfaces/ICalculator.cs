namespace TPO_2.Interfaces;

public interface ICalculator
{
    /**
     * Calculates the sum of two numbers: a + b
     */
    double Sum(double a, double b);
    
    /**
     * Calculates the difference of two numbers: a - b
     */
    double Subtract(double a, double b);
   
    /**
    * Calculates the product of two numbers: a * b
    */
    double Multiply(double a, double b);

    /**
    * Calculates the ratio of number a to number b: a / b
    * Should throw System.ArithmeticException if |b| < 10e-8
    */
    double Divide(double a, double b);
}