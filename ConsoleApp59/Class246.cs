
namespace ConsoleApp59;

public class Class246
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class247().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
