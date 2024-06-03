
namespace ConsoleApp59;

public class Class286
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class287().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
