
namespace ConsoleApp59;

public class Class225
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class226().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
