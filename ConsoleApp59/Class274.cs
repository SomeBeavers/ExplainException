
namespace ConsoleApp59;

public class Class274
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class275().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
