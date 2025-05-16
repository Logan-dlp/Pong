namespace Pong.Commands
{
    public abstract class ACommand
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}