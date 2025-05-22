using System;
using UnityEngine;

namespace Pong.Observers
{
    [CreateAssetMenu(fileName = "MessageScriptable", menuName = "MessageScriptable")]
    public class MessageScriptable : ScriptableObject
    {
        public Action Listeners;
        public void Notify() => Listeners?.Invoke();
    }
}
