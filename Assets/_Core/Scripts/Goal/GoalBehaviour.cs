using System;
using UnityEngine;

namespace Pong.Goal
{
    using Observer;

    [RequireComponent(typeof(Rigidbody2D))]
    public class GoalBehaviour : MonoBehaviour
    {
        private ObserverHandler<GoalEventArgs> _observerHandler = new();

        public void SubscribeToGoal(EventHandler<GoalEventArgs> handler)
        {
            _observerHandler.Subscribe(handler);
        }

        public void UnsubscribeFromGoal(EventHandler<GoalEventArgs> handler)
        {
            _observerHandler.Unsubscribe(handler);
        }

        private void OnCollisionEnter2D(Collision2D collision2D)
        {
            _observerHandler.Notify(new() { Collision2D = collision2D });
        }
    }
}

