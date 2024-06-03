
namespace ConsoleApp59;

public class Class114
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class115().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
