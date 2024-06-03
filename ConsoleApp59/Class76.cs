
namespace ConsoleApp59;

public class Class76
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class77().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
