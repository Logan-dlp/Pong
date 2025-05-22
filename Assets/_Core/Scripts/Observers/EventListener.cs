using UnityEngine;
using UnityEngine.Events;

namespace Pong.Observers
{
    public class EventListener : MonoBehaviour
    {
        [SerializeField] private MessageScriptable _messageScriptable;
        [SerializeField] private UnityEvent _unityEvent;

        private void OnEnable() => _messageScriptable.Listeners += OnEvent;

        private void OnDisable() => _messageScriptable.Listeners -= OnEvent;

        private void OnEvent() => _unityEvent.Invoke();
    }
}