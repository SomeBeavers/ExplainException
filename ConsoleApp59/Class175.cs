
namespace ConsoleApp59;

public class Class175
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class176().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
