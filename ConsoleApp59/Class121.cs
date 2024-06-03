
namespace ConsoleApp59;

public class Class121
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class122().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
