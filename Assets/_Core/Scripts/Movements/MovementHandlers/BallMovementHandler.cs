using UnityEngine;

namespace Pong.Movements.MovementHandlers
{
    public class BallMovementHandler : MovementHandler
    {
        private void Start()
        {
            Vector2 direction = Random.value < 0.5f ? Vector2.left : Vector2.right;
            SetMovementDirection(direction);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Vector2 direction = Vector2.Reflect(_currentDirection, collision.contacts[0].normal);
            if (collision.transform.TryGetComponent(out MovementHandler movementHandler))
            {
                direction -= (Vector2)collision.transform.position - collision.contacts[0].point;
            }
            
            SetMovementDirection(direction.normalized);
        }
    }
}

