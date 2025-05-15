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
        [SerializeField] private bool _isClampedMovement;
        [SerializeField, HideInInspector] private Vector2 _clampYMovement;
        
        protected Vector2 _currentDirection { get; private set; } = Vector2.zero;
        
        private MovementCommandReceiver _movementCommandReceiver;
        private List<MovementCommand> _movementCommandList = new();
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
                MovementCommand movementCommand = _isClampedMovement ? 
                    new(_movementCommandReceiver, gameObject, direction, _clampYMovement, _speedMovement) : 
                    new(_movementCommandReceiver, gameObject, direction, _speedMovement);
                
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
        
        public void SetMovementDirection(Vector2 direction) => _currentDirection = direction;
    }
}