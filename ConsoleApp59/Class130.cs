
namespace ConsoleApp59;

public class Class130
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class131().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
