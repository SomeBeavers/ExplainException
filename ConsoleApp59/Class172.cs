
namespace ConsoleApp59;

public class Class172
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class173().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
