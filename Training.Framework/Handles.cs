using System;
using System.Collections.Generic;
using System.Threading;

namespace Training.Framework
{

    public interface Handles<T>
    {
        void Handle(T message);
    }
    
}
