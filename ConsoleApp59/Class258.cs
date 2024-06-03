
namespace ConsoleApp59;

public class Class258
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class259().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
