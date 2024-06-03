
namespace ConsoleApp59;

public class Class27
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class28().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
