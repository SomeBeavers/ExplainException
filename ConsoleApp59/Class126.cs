
namespace ConsoleApp59;

public class Class126
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class127().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
