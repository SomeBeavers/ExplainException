
namespace ConsoleApp59;

public class Class25
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class26().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
