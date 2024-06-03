
namespace ConsoleApp59;

public class Class221
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class222().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
