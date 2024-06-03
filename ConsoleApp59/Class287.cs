
namespace ConsoleApp59;

public class Class287
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class288().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
