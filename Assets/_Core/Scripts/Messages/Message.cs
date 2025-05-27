using System;
using UnityEngine;

namespace Pong.Messages
{
    [CreateAssetMenu(fileName = "Message", menuName = "Message")]
    public class Message : ScriptableObject
    {
        public Action Listeners;

        public void Notify()
        {
            Listeners?.Invoke();
        }
    }
}
