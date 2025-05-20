using UnityEngine;
using UnityEngine.Events;

namespace Pong.Observers
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class CollisionEventInvoker : MonoBehaviour
    {
        [SerializeField] private UnityEvent OnCollisionEvent;
        private void OnCollisionEnter2D(Collision2D collision) => OnCollisionEvent?.Invoke();
    }
}

