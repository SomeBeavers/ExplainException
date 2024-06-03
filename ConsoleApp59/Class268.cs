
namespace ConsoleApp59;

public class Class268
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class269().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
