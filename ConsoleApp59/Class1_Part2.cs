namespace ConsoleApp59;

public class Class1_2
{
    public void ThrowException(string parameter)
    {
        throw new MyException($"My custom exception {parameter}");
    }
}