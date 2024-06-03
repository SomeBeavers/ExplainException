
namespace ConsoleApp59;

public class Class111
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class112().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
