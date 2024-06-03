
namespace ConsoleApp59;

public class Class8
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class9().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
