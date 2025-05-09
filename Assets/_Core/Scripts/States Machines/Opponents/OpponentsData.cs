using UnityEngine;

namespace Pong.StatesMachines.Opponents
{
    using Movements;
    
    public struct OpponentsData
    {
        public GameObject OpponentGameObject { get; set; }
        public MovementHandler OpponentsMovementHandler { get; set; }
        public GameObject BallGameObjectReference { get; set; }
    }
}