
namespace ConsoleApp59;

public class Class163
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class164().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
