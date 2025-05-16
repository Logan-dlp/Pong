using System;
using UnityEngine;

namespace Pong.Observer
{
    public class EventScriptable<T> : ScriptableObject
    {
        private event Action<T> Listeners;

        public void Subscribe(Action<T> listener)
        {
            Listeners += listener;
        }

        public void Unsubscribe(Action<T> listener)
        {
            Listeners -= listener;
        }

        public void Notify(T value)
        {
            Listeners?.Invoke(value);
        }
    }
}
