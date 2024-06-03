
namespace ConsoleApp59;

public class Class43
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class44().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
