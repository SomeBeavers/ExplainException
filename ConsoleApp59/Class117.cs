
namespace ConsoleApp59;

public class Class117
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class118().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
