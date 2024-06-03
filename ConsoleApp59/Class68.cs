
namespace ConsoleApp59;

public class Class68
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class69().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
