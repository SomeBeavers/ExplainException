
namespace ConsoleApp59;

public class Class26
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class27().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
