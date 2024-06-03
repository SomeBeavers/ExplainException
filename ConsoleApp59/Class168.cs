
namespace ConsoleApp59;

public class Class168
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class169().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
