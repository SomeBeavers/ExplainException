
namespace ConsoleApp59;

public class Class102
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class103().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
