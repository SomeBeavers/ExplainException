
namespace ConsoleApp59;

public class Class24
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class25().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
