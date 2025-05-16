using Pong.Observer;
using UnityEngine;

namespace Pong.Goals
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class GoalBehaviour : MonoBehaviour
    {
        [SerializeField] private EventScriptable _goalScoredEvent;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _goalScoredEvent.Notify();
        }
    }
}
