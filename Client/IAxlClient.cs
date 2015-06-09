using System;
using System.Threading.Tasks;

namespace AxlNetClient
{
    public interface IAxlClient
    {
        Task<IAxlResult<TResultValue>> ExecuteAsync<TResultValue>(Func<AXLPortClient, Task<TResultValue>> execute);

        IAxlResult<TResultValue> Execute<TResultValue>(Func<AXLPortClient, TResultValue> execute);

        Task<IAxlResult<bool>> ExecuteAsync(Func<AXLPortClient, Task> execute);

        IAxlResult<bool> Execute(Action<AXLPortClient> execute);
    }
}