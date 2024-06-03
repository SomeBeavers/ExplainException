
namespace ConsoleApp59;

public class Class201
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class202().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
