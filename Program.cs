using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace preview
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // 1. query syntax - looks the same. Note await location.
            var res = from l in getLines() where l.StartsWith("#") select l;
            await foreach(var line in res) {
                System.Console.WriteLine(line);
            }
            System.Console.WriteLine("Done 1!");

            // 2. Using fluent with async execution. Note await location.
             var ares = await getLines().Where(l=>l.StartsWith("#")).Select(l=>l)
                                .ToListAsync();
            foreach(var line in ares) {
                System.Console.WriteLine(line);
            }
            System.Console.WriteLine("Done 2!");

            // 3. Using fluent with await on the iterator - Note await location.
            res = getLines().Where(l=>l.StartsWith("#")).Select(l=>l);
            await foreach(var line in res) {
                System.Console.WriteLine(line);
            }
            System.Console.WriteLine("Done 3!");
        }

        static async IAsyncEnumerable<string> getLines() {
            var rdr = new StreamReader(@"c:\users\mike\repos\fintools\readme.md");
            while (!rdr.EndOfStream) {
                var line = await rdr.ReadLineAsync();
                yield return line;
            }
        }
    }
}
