using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;

namespace UnfluentMigrations.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var template = File.ReadAllText(@"c:\temp\template.txt");
            var outFolder = @"C:\code\UnfluentMigrations\UnfluentMigrations\Dialects\SqlConversion\Operations";
            var types = typeof(UnfluentMigrations.Operations.MigrationOperationBase)
                .GetTypeInfo().Assembly.GetExportedTypes().Where(x => x.Name.EndsWith("Operation"))
                .Select(x => x.GetTypeInfo())
                .Where(x => !x.IsAbstract && !x.IsInterface)
                .Select(x => x.Name.Replace("Operation",""))
                .OrderBy(x=>x)
                .ToList();
            foreach (var t in types)
            {
                var txt = template.Replace("OPERATIONNAME", t);
                var path = Path.Combine(outFolder, $"{t}Renderer.cs");
                File.WriteAllText(path,txt);

            }
        }
    }
}
