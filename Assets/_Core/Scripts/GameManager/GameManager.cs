using UnityEngine;

namespace Pong.GameManager
{
    using Goal;
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private GoalBehaviour _goalLeft, _goalRight;
        public static GameManager Instance { get; private set; }

        private void Awake()
        {
            SingletonCheck();

            _goalLeft.SubscribeToGoal(OnGoalScored);
            _goalRight.SubscribeToGoal(OnGoalScored);

            SpawnBall();
        }

        private void SingletonCheck()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        private void OnGoalScored(object sender, GoalEventArgs e)
        {
            Destroy(e.Collision2D.gameObject);
            SpawnBall();
        }

        private void SpawnBall()
        {
            Debug.Log("Factory.SpawnBall()");
        }
    }
}

