
namespace ConsoleApp59;

public class Class12
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class13().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
