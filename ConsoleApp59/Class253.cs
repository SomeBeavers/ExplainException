
namespace ConsoleApp59;

public class Class253
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class254().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
