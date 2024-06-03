
namespace ConsoleApp59;

public class Class232
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class233().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
