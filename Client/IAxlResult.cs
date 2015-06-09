using System;

namespace AxlNetClient
{
    public interface IAxlResult<TResult>
    {
        TResult Value { get; set; }

        Exception Exception { get; set; }
    }
}