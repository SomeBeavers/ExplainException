
namespace ConsoleApp59;

public class Class281
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class282().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
