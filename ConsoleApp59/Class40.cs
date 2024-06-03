
namespace ConsoleApp59;

public class Class40
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class41().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
