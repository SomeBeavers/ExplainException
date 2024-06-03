
namespace ConsoleApp59;

public class Class243
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class244().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
