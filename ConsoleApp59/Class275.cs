
namespace ConsoleApp59;

public class Class275
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class276().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
