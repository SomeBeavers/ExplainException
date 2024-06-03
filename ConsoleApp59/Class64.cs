
namespace ConsoleApp59;

public class Class64
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class65().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
