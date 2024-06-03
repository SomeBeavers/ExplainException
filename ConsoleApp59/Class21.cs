
namespace ConsoleApp59;

public class Class21
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class22().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
