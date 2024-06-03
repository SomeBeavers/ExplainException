
namespace ConsoleApp59;

public class Class60
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class61().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
