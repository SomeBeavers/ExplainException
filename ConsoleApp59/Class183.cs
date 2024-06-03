
namespace ConsoleApp59;

public class Class183
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class184().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
