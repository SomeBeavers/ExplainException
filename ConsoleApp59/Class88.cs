
namespace ConsoleApp59;

public class Class88
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class89().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
