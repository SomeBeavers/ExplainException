
namespace ConsoleApp59;

public class Class152
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class153().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
