
namespace ConsoleApp59;

public class Class85
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class86().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
