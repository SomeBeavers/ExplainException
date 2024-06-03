
namespace ConsoleApp59;

public class Class203
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class204().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
