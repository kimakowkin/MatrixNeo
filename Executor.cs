using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
internal class Executor
{
    private static void Main(string[] args)
    {
        var a = Assembly.LoadFrom(@"C:\dotnet\ConsoleApp\obj\Debug\net7.0\ref\ConsoleApp.dll");
    }
}

namespace ConsoleApp
{
    internal class Executor
    {
    }
}
