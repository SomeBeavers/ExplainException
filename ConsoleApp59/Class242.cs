
namespace ConsoleApp59;

public class Class242
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class243().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
