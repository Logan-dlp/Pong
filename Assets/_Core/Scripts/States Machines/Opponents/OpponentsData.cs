using UnityEngine;

namespace Pong.StatesMachines.Opponents
{
    using Movements;
    
    public struct OpponentsData
    {
        public GameObject OpponentGameObject { get; set; }
        public MovementHandler OpponentsMovementHandler { get; set; }
        public GameObject PlayerGameObjectReference { get; set; }
        public GameObject BallGameObjectReference { get; set; }
        public Vector2 TimeToExecuteState { get; set; }
        public float BallDetectionDistance { get; set; }
        public float BallDetectionErrorMargin { get; set; }
    }
}