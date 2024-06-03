
namespace ConsoleApp59;

public class Class122
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class123().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
