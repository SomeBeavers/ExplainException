
namespace ConsoleApp59;

public class Class234
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class235().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
