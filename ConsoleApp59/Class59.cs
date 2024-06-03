
namespace ConsoleApp59;

public class Class59
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class60().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
