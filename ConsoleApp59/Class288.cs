
namespace ConsoleApp59;

public class Class288
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class289().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
