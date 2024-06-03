
namespace ConsoleApp59;

public class Class278
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class279().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
