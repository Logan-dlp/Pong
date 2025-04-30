using UnityEngine;

namespace ControllerAI
{
    [RequireComponent(typeof(ControllerAIData))]
    public class ControllerAIBehaviour : MonoBehaviour
    {
        private IControllerAIState _controllerAIState;
        private ControllerAIData _controllerAIData;

        private void Awake()
        {
            _controllerAIData = GetComponent<ControllerAIData>();
            TransitionTo(new StayIdle());
        }

        public void TransitionTo(IControllerAIState nextState)
        {
            _controllerAIState?.Exit(_controllerAIData);
            _controllerAIState = nextState;
            _controllerAIState.Enter(_controllerAIData);
        }

        private void FixedUpdate()
        {
            IControllerAIState newState = _controllerAIState.Update(_controllerAIData);
            if (newState != null)
            {
                TransitionTo(newState);
            }
        }
    }
}