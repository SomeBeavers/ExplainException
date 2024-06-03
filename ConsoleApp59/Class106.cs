
namespace ConsoleApp59;

public class Class106
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class107().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
