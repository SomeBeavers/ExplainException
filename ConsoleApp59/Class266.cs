
namespace ConsoleApp59;

public class Class266
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class267().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
