
namespace ConsoleApp59;

public class Class14
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class15().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
