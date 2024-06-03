
namespace ConsoleApp59;

public class Class57
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class58().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
