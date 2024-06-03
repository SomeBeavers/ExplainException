
namespace ConsoleApp59;

public class Class202
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class203().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
