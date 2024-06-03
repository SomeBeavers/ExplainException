
namespace ConsoleApp59;

public class Class257
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class258().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
