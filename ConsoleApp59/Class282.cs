
namespace ConsoleApp59;

public class Class282
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class283().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
