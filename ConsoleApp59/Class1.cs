namespace ConsoleApp59;

public class Class1
{
    public void ThrowException()
    {
        throw new MyException("My custom exception");
    }

    public void Test1()
    {
        try
        {
            ThrowException();
        }
        catch (MyException e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
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