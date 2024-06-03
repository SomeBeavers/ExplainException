
namespace ConsoleApp59;

public class Class214
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class215().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
