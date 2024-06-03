
namespace ConsoleApp59;

public class Class28
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class29().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
