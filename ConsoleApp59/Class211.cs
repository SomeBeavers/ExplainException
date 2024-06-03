
namespace ConsoleApp59;

public class Class211
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class212().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
