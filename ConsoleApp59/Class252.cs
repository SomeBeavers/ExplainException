
namespace ConsoleApp59;

public class Class252
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class253().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
