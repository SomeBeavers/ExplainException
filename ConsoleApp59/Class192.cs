
namespace ConsoleApp59;

public class Class192
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class193().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
