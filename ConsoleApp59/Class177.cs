
namespace ConsoleApp59;

public class Class177
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class178().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
