using System;

namespace Pong.Observer
{
    public class ObserverHandler<TEventArgs> where TEventArgs : EventArgs
    {
        private event EventHandler<TEventArgs> EventHandler;

        public void Subscribe(EventHandler<TEventArgs> eventHandler)
        {
            EventHandler += eventHandler;
        }

        public void Unsubscribe(EventHandler<TEventArgs> eventHandler)
        {
            EventHandler -= eventHandler;
        }

        public void Notify(TEventArgs eventArgs)
        {
            EventHandler?.Invoke(this, eventArgs);
        }
    }
}
