
namespace ConsoleApp59;

public class Class187
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class188().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
