using UnityEngine;

namespace Pong.Movements
{
    public class BallMovementHandler : MovementHandler
    {
        private void Start()
        {
            Vector2 vector2 = Random.value < 0.5f ? Vector2.left : Vector2.right;
            SetMovementDirection(vector2);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Vector2 direction = Vector2.Reflect(_currentDirection, collision.contacts[0].normal);

            if (collision.transform.TryGetComponent(out MovementHandler movementHandler))
            {
                direction -= (Vector2)collision.transform.position - collision.contacts[0].point;
            }

            Debug.Log(direction.normalized);
            SetMovementDirection(direction.normalized);
        }
    }
}

