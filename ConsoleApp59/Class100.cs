
namespace ConsoleApp59;

public class Class100
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class101().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
