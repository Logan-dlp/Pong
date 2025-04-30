using ControllerAI;
using UnityEngine;

public class FollowBall : IControllerAIState
{
    public void Enter(ControllerAIData controllerAIData)
    {

    }

    public void Exit(ControllerAIData controllerAIData)
    {

    }

    public IControllerAIState Update(ControllerAIData controllerAIData)
    {
        float BallAlignment = controllerAIData.Ball.transform.position.y - controllerAIData.PadAI.transform.position.y;
        if (BallAlignment > 0)
        {
            Debug.Log("controllerAIData.PadAI.Up");
        }
        else if (BallAlignment < 0)
        {
            Debug.Log("controllerAIData.PadAI.Down");
        }

        if (Mathf.Abs(controllerAIData.Ball.transform.position.y - controllerAIData.PadAI.transform.position.y) < controllerAIData.BallAlignmentAcceptance)
        {
            return new StayIdle();
        }

        return null;
    }
}
