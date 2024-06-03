
namespace ConsoleApp59;

public class Class65
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class66().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
