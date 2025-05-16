using Pong.Observer;
using UnityEngine;

public class GoalTestListener : EventListener<GoalScoredEventData, GoalScoredEvent>
{
    protected override void OnEvent(GoalScoredEventData data) 
    {
        Debug.Log(data.Goal.name.ToString());
    }
}
