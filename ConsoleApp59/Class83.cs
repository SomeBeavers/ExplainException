
namespace ConsoleApp59;

public class Class83
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class84().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
