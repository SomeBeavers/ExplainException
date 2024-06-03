
namespace ConsoleApp59;

public class Class78
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class79().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
