using System;
using System.Collections.Generic;
using System.Text;

namespace clothing
{
    public interface ILogger<T>
    {
        event Action<T> Log;
        void RaiseEvent(T obj);
    }
}
