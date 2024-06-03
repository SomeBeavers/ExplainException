
namespace ConsoleApp59;

public class Class198
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class199().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
