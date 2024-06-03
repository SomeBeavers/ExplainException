
namespace ConsoleApp59;

public class Class7
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class8().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
