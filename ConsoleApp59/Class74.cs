
namespace ConsoleApp59;

public class Class74
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class75().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
