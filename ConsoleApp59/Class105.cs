
namespace ConsoleApp59;

public class Class105
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class106().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
