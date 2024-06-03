
namespace ConsoleApp59;

public class Class144
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class145().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
