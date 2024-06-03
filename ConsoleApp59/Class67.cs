
namespace ConsoleApp59;

public class Class67
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class68().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
