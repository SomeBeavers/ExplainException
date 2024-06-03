
namespace ConsoleApp59;

public class Class75
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class76().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
