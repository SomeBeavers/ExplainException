
namespace ConsoleApp59;

public class Class210
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class211().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
