
namespace ConsoleApp59;

public class Class279
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class280().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
