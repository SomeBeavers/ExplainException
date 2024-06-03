
namespace ConsoleApp59;

public class Class86
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class87().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
