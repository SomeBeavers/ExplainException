
namespace ConsoleApp59;

public class Class262
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class263().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
