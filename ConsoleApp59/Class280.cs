
namespace ConsoleApp59;

public class Class280
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class281().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
