
namespace ConsoleApp59;

public class Class80
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class81().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
