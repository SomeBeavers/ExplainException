
namespace ConsoleApp59;

public class Class33
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class34().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
