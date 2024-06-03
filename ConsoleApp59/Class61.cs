
namespace ConsoleApp59;

public class Class61
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class62().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
