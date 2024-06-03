
namespace ConsoleApp59;

public class Class181
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class182().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
