
namespace ConsoleApp59;

public class Class9
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class10().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
