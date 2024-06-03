
namespace ConsoleApp59;

public class Class132
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class133().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
