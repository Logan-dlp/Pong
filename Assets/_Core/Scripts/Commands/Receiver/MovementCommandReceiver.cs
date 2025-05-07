using UnityEngine;

namespace Pong.Commands.Receiver
{
    public class MovementCommandReceiver
    {
        public void MovementOperation(GameObject gameObjectToMove, Vector2 direction, float speed)
        {
            gameObjectToMove.transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}