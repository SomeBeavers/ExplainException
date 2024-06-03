
namespace ConsoleApp59;

public class Class273
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class274().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
