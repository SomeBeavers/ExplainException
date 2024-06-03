
namespace ConsoleApp59;

public class Class264
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class265().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
