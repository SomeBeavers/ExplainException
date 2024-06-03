
namespace ConsoleApp59;

public class Class145
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class146().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
