using UnityEngine;

namespace Pong.Observer 
{
    public struct GoalScoredEventData
    {
        public GameObject Goal, Ball;
        public GoalScoredEventData(GameObject goal, GameObject ball )
        {
            Goal = goal;
            Ball = ball;
        }
    }

    [CreateAssetMenu(fileName = "GoalScoredEvent", menuName = "EventScriptable/GoalScoredEvent")]
    public class GoalScoredEvent : EventScriptable<GoalScoredEventData> { }
}