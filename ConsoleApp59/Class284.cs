
namespace ConsoleApp59;

public class Class284
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class285().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
