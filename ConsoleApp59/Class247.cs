
namespace ConsoleApp59;

public class Class247
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class248().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
