
namespace ConsoleApp59;

public class Class296
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class297().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
