
namespace ConsoleApp59;

public class Class17
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class18().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
