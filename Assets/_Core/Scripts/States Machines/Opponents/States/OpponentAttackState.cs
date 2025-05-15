using UnityEngine;

namespace Pong.StatesMachines.Opponents.States
{
    public class OpponentAttackState : IStates<OpponentsData>
    {
        private float _timeToExecuteState;
        
        public void Enter(OpponentsData data)
        {
            _timeToExecuteState = Random.Range(data.TimeToExecuteState.x, data.TimeToExecuteState.y);
        }

        public IStates<OpponentsData> Update(OpponentsData data)
        {
            if (data.BallGameObjectReference == null)
                return null;
            
            if (Vector2.Distance(data.OpponentGameObject.transform.position, data.BallGameObjectReference.transform.position) < data.BallDetectionDistance)
            {
                float offset = 0;
                if (data.PlayerGameObjectReference.transform.position.y > data.OpponentGameObject.transform.position.y)
                {
                    offset += 1f;
                }
                else if (data.PlayerGameObjectReference.transform.position.y < data.OpponentGameObject.transform.position.y)
                {
                    offset -= 1f;
                }
                
                if (data.OpponentGameObject.transform.position.y + data.BallDetectionErrorMargin < data.BallGameObjectReference.transform.position.y + offset)
                {
                    data.OpponentsMovementHandler.SetMovementDirection(Vector2.up);
                }
                else if (data.OpponentGameObject.transform.position.y - data.BallDetectionErrorMargin > data.BallGameObjectReference.transform.position.y + offset)
                {
                    data.OpponentsMovementHandler.SetMovementDirection(Vector2.down);
                }
                else
                {
                    data.OpponentsMovementHandler.SetMovementDirection(Vector2.zero);
                }
            }
            else
            {
                data.OpponentsMovementHandler.SetMovementDirection(Vector2.zero);
            }
            
            if (_timeToExecuteState > 0)
            {
                _timeToExecuteState -= Time.deltaTime;
                return null;
            }
            
            return new OpponentDefenseState();
        }

        public void Exit(OpponentsData data)
        {
            
        }
    }
}