
namespace ConsoleApp59;

public class Class35
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class36().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
