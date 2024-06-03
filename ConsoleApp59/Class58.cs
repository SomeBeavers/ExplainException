
namespace ConsoleApp59;

public class Class58
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class59().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
