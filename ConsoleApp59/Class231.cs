
namespace ConsoleApp59;

public class Class231
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class232().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
