
namespace ConsoleApp59;

public class Class212
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class213().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
