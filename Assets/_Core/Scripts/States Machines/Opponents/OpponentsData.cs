using UnityEngine;

namespace Pong.StatesMachines.Opponents
{
    using Movements;
    
    public struct OpponentsData
    {
        public GameObject OpponentGameObject { get; set; }
        public MovementHandler OpponentsMovementHandler { get; set; }
        public GameObject PlayerGameObjectReference { get; set; }
        
        /// <summary>
        /// Time to move to the next state.
        /// <param name="x">min time</param>
        /// <param name="y">max time</param>
        /// </summary>
        public Vector2 TimeToExecuteState { get; set; }
        
        // <summary>
        /// The higher the value, the harder the AI is to beat.
        /// </summary>
        public float BallDetectionDistance { get; set; }
        public float BallDetectionErrorMargin { get; set; }
    }
}