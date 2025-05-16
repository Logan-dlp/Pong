using System;
using UnityEngine;

namespace Pong.Observer
{
    [CreateAssetMenu(fileName = "EventScriptable", menuName = "EventScriptable")]
    public class EventScriptable : ScriptableObject
    {
        public event Action Listeners;

        public void Notify() => Listeners?.Invoke();
    }
}
