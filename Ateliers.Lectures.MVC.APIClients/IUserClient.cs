using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ateliers.Lectures.MVC.APIClients
{
    public interface IUserClient
    {
        Task<IEnumerable<string>> GetUserAll(CancellationToken token = default);

        Task<string> GetUserById(int userId, CancellationToken token = default);
    }
}
