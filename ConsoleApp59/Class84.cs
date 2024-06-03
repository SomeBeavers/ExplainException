
namespace ConsoleApp59;

public class Class84
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class85().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
