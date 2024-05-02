namespace ConsoleApp59;

public partial class Class1
{
    public void Test1(int t)
    {
        try
        {
            new Class1_2().ThrowException($"Test {t}");
        }
        catch (MyException e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}

public class MainClass
{
}

public class MyException : Exception
{
    public MyException() : base("Custom exception message")
    {
        // Additional code here
    }
    public MyException(string message) : base(message)
    {
        // Additional code here
    }
}