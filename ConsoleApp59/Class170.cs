
namespace ConsoleApp59;

public class Class170
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class171().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
