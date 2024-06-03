
namespace ConsoleApp59;

public class Class191
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class192().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
