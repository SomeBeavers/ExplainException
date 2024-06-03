
namespace ConsoleApp59;

public class Class153
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class154().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
