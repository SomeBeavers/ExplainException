
namespace ConsoleApp59;

public class Class251
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class252().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
