
namespace ConsoleApp59;

public class Class276
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class277().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
