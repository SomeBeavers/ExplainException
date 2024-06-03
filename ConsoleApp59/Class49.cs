
namespace ConsoleApp59;

public class Class49
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class50().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
