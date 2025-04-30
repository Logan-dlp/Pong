using ControllerAI;
using UnityEngine;

public class StayIdle : IControllerAIState
{
    public void Enter(ControllerAIData controllerAIData)
    {
        
    }

    public void Exit(ControllerAIData controllerAIData)
    {
        
    }

    public IControllerAIState Update(ControllerAIData controllerAIData)
    {
        if (controllerAIData.Ball != null)
        {
            if (Mathf.Abs(controllerAIData.Ball.transform.position.y - controllerAIData.PadAI.transform.position.y) > controllerAIData.BallAlignmentAcceptance)
            {
                return new FollowBall();
            }
        }
        else
        {
            controllerAIData.FindBall();
        }
        return null;
    }
}
