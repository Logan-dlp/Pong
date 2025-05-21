using UnityEngine;

namespace Pong.Goals 
{
    //Only for Test
    public class GoalListenerTestBehaviour : MonoBehaviour
    {
        public void GoalLeftScored() => Debug.Log("RightScore ++");
        public void GoalRightScored() => Debug.Log("LeftScore ++");
    }
}

