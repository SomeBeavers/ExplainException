
namespace ConsoleApp59;

public class Class62
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class63().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
