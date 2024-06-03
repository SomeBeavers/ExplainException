
namespace ConsoleApp59;

public class Class99
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class100().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
