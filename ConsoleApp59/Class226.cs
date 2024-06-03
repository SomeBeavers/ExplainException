
namespace ConsoleApp59;

public class Class226
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class227().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
