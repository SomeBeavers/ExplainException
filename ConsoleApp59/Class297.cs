
namespace ConsoleApp59;

public class Class297
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class298().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
