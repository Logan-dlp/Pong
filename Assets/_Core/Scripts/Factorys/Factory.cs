using UnityEngine;

namespace Pong.Factorys
{
    public abstract class Factory<T> : MonoBehaviour
    {
        public abstract void Create();
        public abstract void Destroy(T instance);
        public abstract void DestroyAll();
    }
}