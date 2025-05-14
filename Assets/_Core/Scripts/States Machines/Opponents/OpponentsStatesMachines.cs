using UnityEngine;

namespace Pong.StatesMachines.Opponents
{
    using Movements;
    using States;
    
    [RequireComponent(typeof(MovementHandler))]
    public class OpponentsStatesMachines : MonoBehaviour
    {
        [SerializeField] private GameObject _playerGameObjectReference;
        [SerializeField] private GameObject _ballGameObjectReference;
        
        /// <summary>
        /// Time to move to the next state.
        /// <param name="x">min time</param>
        /// <param name="y">max time</param>
        /// </summary>
        [SerializeField] private Vector2 _timeToExecuteState = new(5f, 10f);
        
        /// <summary>
        /// The higher the value, the harder the AI is to beat.
        /// </summary>
        [SerializeField] private float _ballDetectionDistance = 10f;
        [SerializeField] private float _ballDetectionErrorMargin = .3f;
        
        private IStates<OpponentsData> _currentStates;
        private OpponentsData _currentData;
        
        private void Awake()
        {
            _currentData = new OpponentsData
            {
                OpponentGameObject = gameObject,
                OpponentsMovementHandler = GetComponent<MovementHandler>(),
                PlayerGameObjectReference = _playerGameObjectReference,
                BallGameObjectReference = _ballGameObjectReference,
                TimeToExecuteState = _timeToExecuteState,
                BallDetectionDistance = _ballDetectionDistance,
                BallDetectionErrorMargin = _ballDetectionErrorMargin
            };
            
            TransitionTo(new OpponentDefenseState());
        }

        private void Update()
        {
            IStates<OpponentsData> nextState = _currentStates?.Update(_currentData);
            if (nextState != null)
            {
                TransitionTo(nextState);
            }
        }
        
        private void TransitionTo(IStates<OpponentsData> nextState)
        {
            _currentStates?.Exit(_currentData);
            _currentStates = nextState;
            _currentStates?.Enter(_currentData);
        }
    }
}