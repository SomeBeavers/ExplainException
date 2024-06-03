
namespace ConsoleApp59;

public class Class77
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class78().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
