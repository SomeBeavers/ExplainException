
namespace ConsoleApp59;

public class Class292
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class293().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
