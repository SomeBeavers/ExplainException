
namespace ConsoleApp59;

public class Class66
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class67().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
