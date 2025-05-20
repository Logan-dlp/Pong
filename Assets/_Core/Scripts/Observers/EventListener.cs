using UnityEngine;
using UnityEngine.Events;

namespace Pong.Observers
{
    public class EventListener : MonoBehaviour
    {
        [SerializeField] private MessageScriptable _eventScriptable;
        [SerializeField] private UnityEvent _unityEvent;

        private void OnEnable() => _eventScriptable.Listeners += OnEvent;

        private void OnDisable() => _eventScriptable.Listeners -= OnEvent;

        private void OnEvent() => _unityEvent.Invoke();
    }
}