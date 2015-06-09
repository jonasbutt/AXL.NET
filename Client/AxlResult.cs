using System;

namespace AxlNetClient
{
    public class AxlResult<TResult> : IAxlResult<TResult>
    {
        public TResult Value { get; set; }

        public Exception Exception { get; set; }
    }
}