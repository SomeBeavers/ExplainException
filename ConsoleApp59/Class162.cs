
namespace ConsoleApp59;

public class Class162
{
    public void ThrowException(string parameter)
    {
        try
        {
            var list = new List<string>() { "" };
            var enumerable = list.Where(x => x.Length > 0);
            enumerable.ToList().ForEach(x => Console.WriteLine(x));

            throw new MyException($"My custom exception {parameter} thrown after aaaaaaaaa");

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        //try
        //{
        //    new Class163().ThrowException(parameter);
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine(e);
        //    throw;
        //}
    }
}
