using UnityEngine;
using UnityEngine.Events;

namespace Pong.Observer
{
    public class EventListener : MonoBehaviour
    {
        [SerializeField] private EventScriptable _eventScriptable;
        [SerializeField] private UnityEvent _unityEvent;

        private void OnEnable()
        {
            _eventScriptable.Listeners += OnEvent;
        }

        private void OnDisable()
        {
            _eventScriptable.Listeners -= OnEvent;
        }

        private void OnEvent() 
        {
            _unityEvent.Invoke();
        }
    }
}