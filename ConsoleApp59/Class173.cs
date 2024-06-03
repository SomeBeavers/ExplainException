
namespace ConsoleApp59;

public class Class173
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class174().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
