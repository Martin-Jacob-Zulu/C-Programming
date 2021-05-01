using System;
using System.Linq;
using System.Reflection;

namespace C__Programming
{
    class Program
    {
        static void Main(String[] args)
        {
            foreach (var i in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                var a = Assembly.Load(new AssemblyName(i.FullName));

                int methodCount = 0;

                foreach (var j in a.DefinedTypes)
                {
                    methodCount += j.GetMethods().Count();
                }

                Console.WriteLine(
                    "{0:N0} types with {1:N0} methods in {2} assembly.",
                    arg0: a.DefinedTypes.Count(),
                    arg1: methodCount,
                    arg2: i.Name
                );
            }

        }
    }
}
