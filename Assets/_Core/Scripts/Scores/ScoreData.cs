using UnityEngine;

namespace Pong.Scores
{
    [CreateAssetMenu(fileName = "ScoreData", menuName = "ScoreData")]
    public class ScoreData : ScriptableObject, IScore
    {
        private int _score;
        public int Score => _score;
        
        public void AddPoints(int points)
        {
            _score += points;
        }
    }
}
