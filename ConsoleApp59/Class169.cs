
namespace ConsoleApp59;

public class Class169
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class170().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
