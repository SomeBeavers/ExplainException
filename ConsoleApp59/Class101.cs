
namespace ConsoleApp59;

public class Class101
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class102().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
