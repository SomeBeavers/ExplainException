
namespace ConsoleApp59;

public class Class41
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class42().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
