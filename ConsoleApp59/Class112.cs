
namespace ConsoleApp59;

public class Class112
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class113().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
