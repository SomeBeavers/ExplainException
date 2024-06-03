
namespace ConsoleApp59;

public class Class36
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class37().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
