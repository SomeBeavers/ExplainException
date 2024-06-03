
namespace ConsoleApp59;

public class Class215
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class216().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
