
namespace ConsoleApp59;

public class Class161
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class162().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
