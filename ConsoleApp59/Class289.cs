
namespace ConsoleApp59;

public class Class289
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class290().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
