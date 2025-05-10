using UnityEngine;

namespace Pong.StatesMachines.Opponents.States
{
    public class OpponentDefenseState : IStates<OpponentsData>
    {
        public void Enter(OpponentsData data)
        {
            
        }

        public IStates<OpponentsData> Update(OpponentsData data)
        {
            if (Vector2.Distance(data.OpponentGameObject.transform.position, data.BallGameObjectReference.transform.position) < 7f)
            {
                if (Mathf.Abs(data.OpponentGameObject.transform.position.y - data.BallGameObjectReference.transform.position.y) < .3f)
                {
                    data.OpponentsMovementHandler.SetMovementDirection(Vector2.zero);
                }
                else if (data.OpponentGameObject.transform.position.y < data.BallGameObjectReference.transform.position.y)
                {
                    data.OpponentsMovementHandler.SetMovementDirection(Vector2.up);
                }
                else if (data.OpponentGameObject.transform.position.y > data.BallGameObjectReference.transform.position.y)
                {
                    data.OpponentsMovementHandler.SetMovementDirection(Vector2.down);
                }
            }
            else
            {
                data.OpponentsMovementHandler.SetMovementDirection(Vector2.zero);
            }
            
            return null;
        }

        public void Exit(OpponentsData data)
        {
            
        }
    }
}