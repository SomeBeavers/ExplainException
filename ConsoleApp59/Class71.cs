
namespace ConsoleApp59;

public class Class71
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class72().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
