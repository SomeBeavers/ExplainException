
namespace ConsoleApp59;

public class Class53
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class54().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
