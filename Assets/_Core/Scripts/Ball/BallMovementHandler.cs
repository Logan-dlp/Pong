using Pong.Movements;
using UnityEngine;

namespace Pong.Ball
{
    public class BallMovementHandler : MovementHandler
    {
        private void Start()
        {
            Vector2 direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
            SetMovementDirection(direction);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Vector2 targetDirection = Vector2.Reflect(_currentDirection, collision.contacts[0].normal);

            if (collision.transform.TryGetComponent(out MovementHandler movementHandler))
            {
                targetDirection -= (Vector2)collision.transform.position - collision.contacts[0].point;
            }

            SetMovementDirection(targetDirection.normalized);
        }
    }
}

