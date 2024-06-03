
namespace ConsoleApp59;

public class Class227
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class228().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
