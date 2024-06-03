
namespace ConsoleApp59;

public class Class205
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class206().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
