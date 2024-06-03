
namespace ConsoleApp59;

public class Class92
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class93().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
