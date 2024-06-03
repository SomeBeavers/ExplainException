
namespace ConsoleApp59;

public class Class104
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class105().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
