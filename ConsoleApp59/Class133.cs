
namespace ConsoleApp59;

public class Class133
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class134().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
