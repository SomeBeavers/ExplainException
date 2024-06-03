
namespace ConsoleApp59;

public class Class120
{
    public void ThrowException(string parameter)
    {
        try
        {
            var list = new List<string>() { "" };
            var enumerable = list.Where(x => x.Length > 0);
            enumerable.ToList().ForEach(x => Console.WriteLine(x));

            throw new MyException($"My custom exception {parameter} thrown after aaaaaaaaa");

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
