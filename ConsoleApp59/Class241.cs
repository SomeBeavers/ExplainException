
namespace ConsoleApp59;

public class Class241
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class242().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
