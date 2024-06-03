
namespace ConsoleApp59;

public class Class224
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class225().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
