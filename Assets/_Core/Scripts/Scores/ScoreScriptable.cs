using UnityEngine;
using UnityEngine.Events;

namespace Pong.Scores
{
    [CreateAssetMenu(fileName = "ScoreScriptable", menuName = "ScoreScriptable")]
    public class ScoreScriptable : ScriptableObject
    {
        [SerializeField] private UnityEvent OnScoreChanged;
        [SerializeField] private int _score = 0;
        public int Score
        {
            get { return _score; }
            set
            {
                _score = value;
                OnScoreChanged?.Invoke();
            }
        }

        public void AddPoint() => Score++;
    }
}
