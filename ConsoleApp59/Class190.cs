
namespace ConsoleApp59;

public class Class190
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class191().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
