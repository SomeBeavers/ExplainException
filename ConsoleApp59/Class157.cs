
namespace ConsoleApp59;

public class Class157
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class158().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
