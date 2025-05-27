using UnityEngine;

namespace Pong.Scores
{
    [CreateAssetMenu(fileName = "ScoreData", menuName = "ScoreData")]
    public class ScoreData : ScriptableObject
    {
        public int Score = 0;
        public void AddPoint() => Score++;
    }
}
