
namespace ConsoleApp59;

public class Class116
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class117().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
