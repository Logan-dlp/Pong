using Pong.Observer;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class GoalBehaviour : MonoBehaviour
{
    [SerializeField] private GoalScoredEvent _goalScoredEvent;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _goalScoredEvent.Notify(new(gameObject, collision.gameObject));
    }
}
