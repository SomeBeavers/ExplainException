
namespace ConsoleApp59;

public class Class271
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class272().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
