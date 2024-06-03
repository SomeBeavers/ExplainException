
namespace ConsoleApp59;

public class Class245
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class246().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
