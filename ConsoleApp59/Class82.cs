
namespace ConsoleApp59;

public class Class82
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class83().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
