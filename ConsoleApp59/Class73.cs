
namespace ConsoleApp59;

public class Class73
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class74().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
