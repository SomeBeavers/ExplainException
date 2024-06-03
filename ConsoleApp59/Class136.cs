
namespace ConsoleApp59;

public class Class136
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class137().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
