
namespace ConsoleApp59;

public class Class96
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class97().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
