
namespace ConsoleApp59;

public class Class216
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class217().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
