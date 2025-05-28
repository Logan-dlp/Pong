using TMPro;
using UnityEngine;

namespace Pong.Scores 
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ScoreDisplayBehaviour : MonoBehaviour
    {
        [SerializeField] private ScoreData _scoreData;
        
        private TextMeshProUGUI _scoreDisplay;

        private void Awake()
        {
            _scoreDisplay = GetComponent<TextMeshProUGUI>();
            RefreshDisplayScore();
        }

        public void RefreshDisplayScore()
        {
            _scoreDisplay.text = _scoreData.Score.ToString();
        }
    }
}

