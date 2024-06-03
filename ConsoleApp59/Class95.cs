
namespace ConsoleApp59;

public class Class95
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class96().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
