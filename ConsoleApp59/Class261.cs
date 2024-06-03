
namespace ConsoleApp59;

public class Class261
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class262().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
