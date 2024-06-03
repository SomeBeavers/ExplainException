
namespace ConsoleApp59;

public class Class189
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class190().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
