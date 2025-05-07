using UnityEngine;

namespace Pong.StatesMachines.Opponents
{
    public class OpponentsStatesMachines : MonoBehaviour
    {
        private IStates<OpponentsData> _currentStates;
        private OpponentsData _currentData;

        private void Awake()
        {
            _currentData = new OpponentsData()
            {
                // data
            };
            
            // first state
            // TransitionTo();
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