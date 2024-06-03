
namespace ConsoleApp59;

public class Class46
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class47().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
