using UnityEngine;

namespace Pong.Commands.Receiver
{
    public class MovementCommandReceiver
    {
        public void MovementOperation(GameObject gameObjectToMove, Vector2 direction, Vector2 clampYMovement, float speed)
        {
            gameObjectToMove.transform.Translate(direction * speed * Time.deltaTime);
            gameObjectToMove.transform.position = new Vector3(gameObjectToMove.transform.position.x, 
                                                                Mathf.Clamp(gameObjectToMove.transform.position.y, clampYMovement.x, clampYMovement.y), 
                                                                gameObjectToMove.transform.position.z);
        }
    }
}