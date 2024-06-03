
namespace ConsoleApp59;

public class Class186
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class187().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
