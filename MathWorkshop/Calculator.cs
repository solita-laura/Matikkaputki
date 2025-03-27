namespace MathWorkshop;

public class Calculator
{
    public static int Add(int a, int b) => a + b;

    public static int Multiply(int a, int b) => a * b;

    public static int Divide(int a, int b)
    {
        //if (b == 0) throw new ArgumentException("Cannot divide by zero.");
        return a / b;
    }
}
