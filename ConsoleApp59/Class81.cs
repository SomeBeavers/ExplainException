
namespace ConsoleApp59;

public class Class81
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class82().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
