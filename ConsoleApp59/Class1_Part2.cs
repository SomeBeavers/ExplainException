﻿namespace ConsoleApp59;

public class Class1_2
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class2().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}