using UnityEngine;

namespace Pong.StatesMachines.Opponents.States
{
    public class OpponentDefenseState : IStates<OpponentsData>
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
                if (data.OpponentGameObject.transform.position.y + data.BallDetectionErrorMargin < data.BallGameObjectReference.transform.position.y)
                {
                    data.OpponentsMovementHandler.SetMovementDirection(Vector2.up);
                }
                else if (data.OpponentGameObject.transform.position.y - data.BallDetectionErrorMargin > data.BallGameObjectReference.transform.position.y)
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
            
            return new OpponentAttackState();
        }

        public void Exit(OpponentsData data)
        {
            
        }
    }
}