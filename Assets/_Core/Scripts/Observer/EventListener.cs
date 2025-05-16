using UnityEngine;

namespace Pong.Observer
{
    public abstract class EventListener<T, E> : MonoBehaviour where E : EventScriptable<T>
    {
        [SerializeField] private E _eventScriptable;

        private void OnEnable()
        {
            _eventScriptable?.Subscribe(OnEvent);
        }

        private void OnDisable()
        {
            _eventScriptable?.Unsubscribe(OnEvent);
        }

        protected virtual void OnEvent(T value) { }
    }
}