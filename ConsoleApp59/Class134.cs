
namespace ConsoleApp59;

public class Class134
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class135().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
