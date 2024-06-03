
namespace ConsoleApp59;

public class Class233
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class234().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
