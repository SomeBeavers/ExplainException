
namespace ConsoleApp59;

public class Class63
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class64().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
