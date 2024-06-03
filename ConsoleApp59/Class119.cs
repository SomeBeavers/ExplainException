
namespace ConsoleApp59;

public class Class119
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class120().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
