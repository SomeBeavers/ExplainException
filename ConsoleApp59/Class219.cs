
namespace ConsoleApp59;

public class Class219
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class220().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
