
namespace ConsoleApp59;

public class Class151
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class152().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
