
namespace ConsoleApp59;

public class Class291
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class292().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
