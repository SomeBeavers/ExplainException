
namespace ConsoleApp59;

public class Class267
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class268().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
