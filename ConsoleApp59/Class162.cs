
namespace ConsoleApp59;

public class Class162
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class163().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
