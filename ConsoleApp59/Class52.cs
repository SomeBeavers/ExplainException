
namespace ConsoleApp59;

public class Class52
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class53().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
