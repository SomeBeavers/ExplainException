namespace ConsoleApp59;

public class Class2
{
    public void ThrowException(string parameter)
    {
        try
        {
            var list = new List<string>() { "" };
            var enumerable = list.Where(x => x.Length > 0);
            throw new MyException($"My custom exception {parameter} thrown after aaaaaaaaa");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}