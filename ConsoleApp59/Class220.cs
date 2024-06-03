
namespace ConsoleApp59;

public class Class220
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class221().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
