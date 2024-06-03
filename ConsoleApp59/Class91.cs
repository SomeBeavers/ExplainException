
namespace ConsoleApp59;

public class Class91
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class92().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
