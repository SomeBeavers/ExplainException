
namespace ConsoleApp59;

public class Class180
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class181().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
