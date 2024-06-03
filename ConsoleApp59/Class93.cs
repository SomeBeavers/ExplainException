
namespace ConsoleApp59;

public class Class93
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class94().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
