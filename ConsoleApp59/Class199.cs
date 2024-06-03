
namespace ConsoleApp59;

public class Class199
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class200().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
