using TPO_2;
using TPO_2.Interfaces;

namespace TPO_2_TESTS;

public class Tests
{
    private CalculatorPresenter _calculatorPresenter = new CalculatorPresenter();
    private CalculatorViewMock _calculatorViewMock = new CalculatorViewMock();
    private Random _random = new Random();
    
    [SetUp]
    public void Setup()
    {
        _calculatorPresenter.Calculator = new Calculator();
        _calculatorPresenter.CalculatorView = _calculatorViewMock;
    }

    [Test]
    public void FirstIsNullSum()
    {
        _calculatorViewMock.a = null;
        _calculatorViewMock.b = "1";
        _calculatorPresenter.OnPlusClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse first argument to double"));
    }
    
    [Test]
    public void FirstIsNullSubtract()
    {
        _calculatorViewMock.a = null;
        _calculatorViewMock.b = "1";
        _calculatorPresenter.OnMinusClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse first argument to double"));
    }
    
    [Test]
    public void FirstIsNullMultiply()
    {
        _calculatorViewMock.a = null;
        _calculatorViewMock.b = "1";
        _calculatorPresenter.OnMultiplyClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse first argument to double"));
    }
    
    [Test]
    public void FirstIsNullDivide()
    {
        _calculatorViewMock.a = null;
        _calculatorViewMock.b = "1";
        _calculatorPresenter.OnDivideClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse first argument to double"));
    } 
    
    [Test]
    public void SecondIsNullSum()
    {
        _calculatorViewMock.a = "1";
        _calculatorViewMock.b = null;
        _calculatorPresenter.OnPlusClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse second argument to double"));
    }

    
    [Test]
    public void SecondIsNullSubtract()
    {
        _calculatorViewMock.a = "1";
        _calculatorViewMock.b = null;
        _calculatorPresenter.OnMinusClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse second argument to double"));
    }
    
    [Test]
    public void SecondIsNullMultiply()
    {
        _calculatorViewMock.a = "1";
        _calculatorViewMock.b = null;
        _calculatorPresenter.OnMultiplyClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse second argument to double"));
    }
    
    [Test]
    public void SecondIsNullDivide()
    {
        _calculatorViewMock.a = "1";
        _calculatorViewMock.b = null;
        _calculatorPresenter.OnDivideClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse second argument to double"));
    }
    
    [Test]
    public void DivideByZero()
    {
        _calculatorViewMock.a = "1";
        _calculatorViewMock.b = "0";
        _calculatorPresenter.OnDivideClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Division by zero"));
    }
    
        [Test]
    public void FirstIsNaNSum()
    {
        _calculatorViewMock.a = "not a number";
        _calculatorViewMock.b = "1";
        _calculatorPresenter.OnPlusClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse first argument to double"));
    }
    
    [Test]
    public void FirstIsNaNSubtract()
    {
        _calculatorViewMock.a = "not a number";
        _calculatorViewMock.b = "1";
        _calculatorPresenter.OnMinusClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse first argument to double"));
    }
    
    [Test]
    public void FirstIsNaNMultiply()
    {
        _calculatorViewMock.a = "not a number";
        _calculatorViewMock.b = "1";
        _calculatorPresenter.OnMultiplyClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse first argument to double"));
    }
    
    [Test]
    public void FirstIsNaNDivide()
    {
        _calculatorViewMock.a = "not a number";
        _calculatorViewMock.b = "1";
        _calculatorPresenter.OnDivideClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse first argument to double"));
    } 
    
    [Test]
    public void SecondIsNaNSum()
    {
        _calculatorViewMock.a = "1";
        _calculatorViewMock.b = "not a number";
        _calculatorPresenter.OnPlusClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse second argument to double"));
    }

    
    [Test]
    public void SecondIsNaNSubtract()
    {
        _calculatorViewMock.a = "1";
        _calculatorViewMock.b = "not a number";
        _calculatorPresenter.OnMinusClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse second argument to double"));
    }
    
    [Test]
    public void SecondIsNaNMultiply()
    {
        _calculatorViewMock.a = "1";
        _calculatorViewMock.b = "not a number";
        _calculatorPresenter.OnMultiplyClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse second argument to double"));
    }
    
    [Test]
    public void SecondIsNaNDivide()
    {
        _calculatorViewMock.a = "1";
        _calculatorViewMock.b = "not a number";
        _calculatorPresenter.OnDivideClicked();
        Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Cannot parse second argument to double"));
    }

    [Test]
    [Repeat(50)]
    public void RepeatedSum()
    {
        double a = _random.NextDouble();
        double b = _random.NextDouble();
        _calculatorViewMock.a = a.ToString();
        _calculatorViewMock.b = b.ToString();
        _calculatorPresenter.OnPlusClicked();
        Assert.That(_calculatorViewMock.result, Is.EqualTo(a + b));
    }
    
    [Test]
    [Repeat(50)]
    public void RepeatedSubtract()
    {
        double a = _random.NextDouble();
        double b = _random.NextDouble();
        _calculatorViewMock.a = a.ToString();
        _calculatorViewMock.b = b.ToString();
        _calculatorPresenter.OnMinusClicked();
        Assert.That(_calculatorViewMock.result, Is.EqualTo(a - b));
    }
    
    [Test]
    [Repeat(50)]
    public void RepeatedMultiply()
    {
        double a = _random.NextDouble();
        double b = _random.NextDouble();
        _calculatorViewMock.a = a.ToString();
        _calculatorViewMock.b = b.ToString();
        _calculatorPresenter.OnMultiplyClicked();
        Assert.That(_calculatorViewMock.result, Is.EqualTo(a * b));
    }
    
    [Test]
    [Repeat(50)]
    public void RepeatedDivide()
    {
        double a = _random.NextDouble();
        double b = _random.NextDouble();
        _calculatorViewMock.a = a.ToString();
        _calculatorViewMock.b = b.ToString();
        _calculatorPresenter.OnDivideClicked();
        
        if (Math.Abs(b) < 10e-8)
        {
            Assert.That(_calculatorViewMock.errorMessage, Is.EqualTo("Division by zero"));
        }
        else
        {
            Assert.That(_calculatorViewMock.result, Is.EqualTo(a / b));
        }
       
    }
    
}