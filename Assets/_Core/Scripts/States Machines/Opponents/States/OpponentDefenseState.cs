using UnityEngine;

namespace Pong.StatesMachines.Opponents.States
{
    using Movements.MovementHandlers;
    
    public class OpponentDefenseState : IStates<OpponentsData>
    {
        private float _timeToExecuteState;
        
        public void Enter(OpponentsData data)
        {
            _timeToExecuteState = Random.Range(data.TimeToExecuteState.x, data.TimeToExecuteState.y);
        }

        public IStates<OpponentsData> Update(OpponentsData data)
        {
            GameObject ballReference = GameObject.FindFirstObjectByType<BallMovementHandler>() == null ? null : GameObject.FindFirstObjectByType<BallMovementHandler>().gameObject;
            
            if (ballReference == null)
                return null;
            
            if (Vector2.Distance(data.OpponentGameObject.transform.position, ballReference.transform.position) < data.BallDetectionDistance)
            {
                if (data.OpponentGameObject.transform.position.y + data.BallDetectionErrorMargin < ballReference.transform.position.y)
                {
                    data.OpponentsMovementHandler.SetMovementDirection(Vector2.up);
                }
                else if (data.OpponentGameObject.transform.position.y - data.BallDetectionErrorMargin > ballReference.transform.position.y)
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