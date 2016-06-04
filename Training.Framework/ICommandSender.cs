using System;
using System.Collections.Generic;
using System.Threading;

namespace Training.Framework
{

    public interface ICommandSender
    {
        void Send<T>(T command) where T : Command;

    }
    
}
