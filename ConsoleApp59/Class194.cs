
namespace ConsoleApp59;

public class Class194
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class195().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
