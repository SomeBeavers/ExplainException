
namespace ConsoleApp59;

public class Class174
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class175().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
