
namespace ConsoleApp59;

public class Class182
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class183().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
