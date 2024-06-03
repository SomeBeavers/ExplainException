
namespace ConsoleApp59;

public class Class123
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class124().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
