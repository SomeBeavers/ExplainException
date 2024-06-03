
namespace ConsoleApp59;

public class Class254
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class255().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
