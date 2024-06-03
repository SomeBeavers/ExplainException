
namespace ConsoleApp59;

public class Class11
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class12().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
