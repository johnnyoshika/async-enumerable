using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await foreach (var i in Test().WithCancellation(CancellationToken.None))
                Console.WriteLine(i);

            Console.WriteLine(await Test().Where(i => i > 2).FirstAsync());
        }

        static async IAsyncEnumerable<int> Test()
        {
            yield return 1;
            yield return 2;

            await Task.Delay(1000);

            yield return 3;
            yield return 4;
        }
            
    }
}
