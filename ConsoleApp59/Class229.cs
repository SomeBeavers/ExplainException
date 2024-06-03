
namespace ConsoleApp59;

public class Class229
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class230().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
