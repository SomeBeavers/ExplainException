
namespace ConsoleApp59;

public class Class70
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class71().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
