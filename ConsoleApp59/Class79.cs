
namespace ConsoleApp59;

public class Class79
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class80().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
