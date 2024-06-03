
namespace ConsoleApp59;

public class Class120
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class121().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
