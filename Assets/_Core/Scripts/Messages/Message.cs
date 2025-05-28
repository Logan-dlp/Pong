using System;
using UnityEngine;

namespace Pong.Messages
{
    [CreateAssetMenu(fileName = "Message", menuName = "Message")]
    public class Message : ScriptableObject
    {
        public Action MessageAction;

        public void Notify()
        {
            MessageAction?.Invoke();
        }
    }
}
