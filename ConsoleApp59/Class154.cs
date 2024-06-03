
namespace ConsoleApp59;

public class Class154
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class155().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
