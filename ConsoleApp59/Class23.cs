
namespace ConsoleApp59;

public class Class23
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class24().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
