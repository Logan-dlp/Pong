namespace ControllerAI
{
    public interface IControllerAIState
    {
        public void Enter(ControllerAIData controllerAIData);
        public void Exit(ControllerAIData controllerAIData);
        public IControllerAIState Update(ControllerAIData controllerAIData);
    }
}
