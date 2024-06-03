
namespace ConsoleApp59;

public class Class193
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class194().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
