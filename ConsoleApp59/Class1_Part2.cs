namespace ConsoleApp59;

public class Class1_2
{
    public void ThrowException(string parameter)
    {
        var list = new List<string>() { "" };
        var enumerable = list.Where(x => x.Length > 0);
        throw new MyException($"My custom exception {parameter}");
    }
}