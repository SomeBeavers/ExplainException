
namespace ConsoleApp59;

public class Class48
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class49().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
