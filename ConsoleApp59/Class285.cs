
namespace ConsoleApp59;

public class Class285
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class286().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
