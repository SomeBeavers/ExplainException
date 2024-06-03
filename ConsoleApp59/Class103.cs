
namespace ConsoleApp59;

public class Class103
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class104().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
