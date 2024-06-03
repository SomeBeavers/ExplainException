
namespace ConsoleApp59;

public class Class269
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class270().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
