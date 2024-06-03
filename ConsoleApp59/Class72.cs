
namespace ConsoleApp59;

public class Class72
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class73().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
