
namespace ConsoleApp59;

public class Class283
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class284().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
