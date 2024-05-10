using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ateliers.Lectures.MVC.APIClients
{
    public interface IProductClient
    {
        string ServerPath { get; }

        Task<IEnumerable<string>> GetProductAll(string apiUrl = "", CancellationToken token = default);
    }
}
