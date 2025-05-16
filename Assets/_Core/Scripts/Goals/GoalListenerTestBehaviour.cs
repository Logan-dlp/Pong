using UnityEngine;

namespace Pong.Goals 
{
    public class GoalListenerTestBehaviour : MonoBehaviour
    {
        public void GoalLeftScored() => Debug.Log("RightScore ++");
        public void GoalRightScored() => Debug.Log("LeftScore ++");
    }
}

