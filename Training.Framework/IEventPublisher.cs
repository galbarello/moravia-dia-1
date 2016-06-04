using System;
using System.Collections.Generic;
using System.Threading;

namespace Training.Framework
{

    public interface IEventPublisher
    {
        void Publish<T>(T @event) where T : Event;
    }
}
