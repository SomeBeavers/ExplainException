
namespace ConsoleApp59;

public class Class150
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class151().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
