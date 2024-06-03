
namespace ConsoleApp59;

public class Class158
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class159().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
