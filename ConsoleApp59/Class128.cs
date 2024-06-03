
namespace ConsoleApp59;

public class Class128
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class129().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
