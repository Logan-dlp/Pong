using System;
using UnityEngine;

namespace Pong.Messages
{
    [CreateAssetMenu(fileName = "MessageScriptable", menuName = "MessageScriptable")]
    public class Message : ScriptableObject
    {
        public Action Listeners;

        public void Notify()
        {
            Listeners?.Invoke();
        }
    }
}
