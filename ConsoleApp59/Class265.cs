
namespace ConsoleApp59;

public class Class265
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class266().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
