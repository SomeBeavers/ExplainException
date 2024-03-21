using Nuget;

Console.WriteLine("Hello, World!");
for (int i = 0; i < 3; i++)
{
    if (i == 2)
    {
        new Nuget.Nuget1().Test();
    }
}
