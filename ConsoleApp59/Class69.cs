
namespace ConsoleApp59;

public class Class69
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class70().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
