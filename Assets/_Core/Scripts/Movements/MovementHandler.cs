using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

namespace Pong.Movements
{
    using Commands.Command;
    using Commands.Receiver;
    
    public class MovementHandler : MonoBehaviour
    {
        [SerializeField] private float _speedMovement;
        
        private MovementCommandReceiver _movementCommandReceiver;
        private List<MovementCommand> _movementCommandList = new();
        private Vector2 _currentDirection = Vector2.zero;
        private int _currentCommandIndex = 0;

        private void Awake()
        {
            _movementCommandReceiver = new MovementCommandReceiver();
        }

        private void FixedUpdate()
        {
            ExecuteMovement(_currentDirection);
        }

        private void ExecuteMovement(Vector2 direction)
        {
            if (direction != Vector2.zero)
            {
                MovementCommand movementCommand = new(_movementCommandReceiver, gameObject, direction, _speedMovement);
                movementCommand.Execute();
                _movementCommandList.Add(movementCommand);
                _currentCommandIndex++;
            }
        }

        public void UndoMovement()
        {
            if (_currentCommandIndex > 0)
            {
                _currentCommandIndex--;
                MovementCommand movementCommand = _movementCommandList[_currentCommandIndex];
                movementCommand.UnExecute();
            }
        }

        public void RedoMovement()
        {
            if (_currentCommandIndex < _movementCommandList.Count)
            {
                MovementCommand movementCommand = _movementCommandList[_currentCommandIndex];
                _currentCommandIndex++;
                movementCommand.Execute();
            }
        }
        
        public void SetMovementDirection(InputAction.CallbackContext ctx) => _currentDirection = ctx.performed ? ctx.ReadValue<Vector2>() : Vector2.zero;
    }
}