
namespace ConsoleApp59;

public class Class259
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class260().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
