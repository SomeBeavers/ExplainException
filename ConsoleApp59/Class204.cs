
namespace ConsoleApp59;

public class Class204
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class205().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
