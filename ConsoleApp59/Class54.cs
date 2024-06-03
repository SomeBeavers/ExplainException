
namespace ConsoleApp59;

public class Class54
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class55().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
