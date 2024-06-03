
namespace ConsoleApp59;

public class Class87
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class88().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
