
namespace ConsoleApp59;

public class Class142
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class143().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
