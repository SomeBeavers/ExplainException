
namespace ConsoleApp59;

public class Class108
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class109().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
