using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitTestWinForm
{
    public class PeopleRepositoryAsync
    {
        public async Task<List<string>> GetPeopleList(CancellationToken cancellationToken = new CancellationToken())
        {
            await Task.Delay(1500);
            cancellationToken.ThrowIfCancellationRequested();
            //throw new NotImplementedException("Method not implemented");
            return new List<string>
            {
                "John Smith",  
                "Ivan Ivanov",
                "Joao Fetucini"
            };
        }   

        public async Task DeadlockTestAsync()
        {
            await Task.Delay(1500).ConfigureAwait(false);
            Console.WriteLine("Done!");
        }
    }
}