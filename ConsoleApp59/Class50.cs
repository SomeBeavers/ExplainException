
namespace ConsoleApp59;

public class Class50
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class51().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
