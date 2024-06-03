
namespace ConsoleApp59;

public class Class110
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class111().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
