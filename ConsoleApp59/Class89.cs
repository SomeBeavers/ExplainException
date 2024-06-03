
namespace ConsoleApp59;

public class Class89
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class90().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
