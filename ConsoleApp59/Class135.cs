
namespace ConsoleApp59;

public class Class135
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class136().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
