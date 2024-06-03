
namespace ConsoleApp59;

public class Class32
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class33().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
