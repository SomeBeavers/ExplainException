
namespace ConsoleApp59;

public class Class250
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class251().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
