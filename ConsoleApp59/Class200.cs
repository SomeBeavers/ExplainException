
namespace ConsoleApp59;

public class Class200
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class201().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
