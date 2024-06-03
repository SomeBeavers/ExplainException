
namespace ConsoleApp59;

public class Class10
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class11().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
