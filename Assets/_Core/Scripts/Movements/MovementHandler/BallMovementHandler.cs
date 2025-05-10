using UnityEngine;

namespace Pong.Movements
{
    public class BallMovementHandler : MovementHandler
    {
        private void Start()
        {
            float randomFloat = Random.Range(1f, 2f);
            Vector2 randomDirection = randomFloat > 1.5f ? Vector2.right : Vector2.left;
            
            SetMovementDirection(randomDirection);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            Vector2 targetDirection = Vector2.Reflect(_currentDirection, other.contacts[0].normal);

            if (other.transform.TryGetComponent(out MovementHandler movementHandler))
            {
                targetDirection -= (Vector2)other.transform.position - other.contacts[0].point;
            }
            
            SetMovementDirection(targetDirection.normalized);
        }
    }
}