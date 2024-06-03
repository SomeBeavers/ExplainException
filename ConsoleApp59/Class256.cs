
namespace ConsoleApp59;

public class Class256
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class257().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
