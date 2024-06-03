
namespace ConsoleApp59;

public class Class171
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class172().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
