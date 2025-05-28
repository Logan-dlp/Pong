using UnityEngine;
using UnityEngine.Events;

namespace Pong.Events
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class CollisionEvent : MonoBehaviour
    {
        [SerializeField] private UnityEvent _onCollisionEvent;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _onCollisionEvent?.Invoke();
        } 
    }
}