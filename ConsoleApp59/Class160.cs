
namespace ConsoleApp59;

public class Class160
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class161().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
