
namespace ConsoleApp59;

public class Class230
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class231().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
