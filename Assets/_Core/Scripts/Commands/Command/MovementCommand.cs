using UnityEngine;

namespace Pong.Commands.Command
{
    using Receiver;
    
    public class MovementCommand : ACommand
    {
        private MovementCommandReceiver _receiver;
        
        private GameObject _gameObjectToMove;
        private Vector2 _direction;
        private Vector2 _clampYMovement;
        private float _speed;
        
        public MovementCommand(MovementCommandReceiver receiver, GameObject gameObjectToMove, Vector2 direction, float speed)
        {
            _receiver = receiver;
            _gameObjectToMove = gameObjectToMove;
            _direction = direction;
            _clampYMovement = new Vector2(float.MinValue, float.MaxValue);
            _speed = speed;
        }
        
        public MovementCommand(MovementCommandReceiver receiver, GameObject gameObjectToMove, Vector2 direction, Vector2 clampYMovement, float speed)
        {
            _receiver = receiver;
            _gameObjectToMove = gameObjectToMove;
            _direction = direction;
            _clampYMovement = clampYMovement;
            _speed = speed;
        }
        
        public override void Execute()
        {
            _receiver.MovementOperation(_gameObjectToMove, _direction, _clampYMovement, _speed);
        }

        public override void UnExecute()
        {
            _receiver.MovementOperation(_gameObjectToMove, -_direction, _clampYMovement, _speed);
        }

        public override string ToString()
        {
            return $"{_gameObjectToMove.name} : {_direction} : {_speed.ToString()}";
        }
    }
}