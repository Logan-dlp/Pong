namespace Pong.StatesMachines
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">as datas of states</typeparam>
    public interface IStates<T>  where T : struct
    {
        public void Enter(T data);
        public IStates<T> Update(T data);
        public void Exit(T data);
    }
}