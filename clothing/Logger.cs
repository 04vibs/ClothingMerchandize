using System;
using System.Collections.Generic;
using System.Text;

namespace clothing
{
    class Logger<T> : ILogger<T>
    {
        public event Action<T> Log;

        public void RaiseEvent(T obj)
        {
            Log.Invoke(obj);
        }
    }
}
