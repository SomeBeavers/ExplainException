
namespace ConsoleApp59;

public class Class42
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class43().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
