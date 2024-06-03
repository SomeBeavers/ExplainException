
namespace ConsoleApp59;

public class Class16
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class17().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
