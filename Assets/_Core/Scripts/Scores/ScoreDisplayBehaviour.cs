using TMPro;
using UnityEngine;

namespace Pong.Scores 
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ScoreDisplayBehaviour : MonoBehaviour
    {
        private TextMeshProUGUI _scoreDisplay;
        [SerializeField] private ScoreScriptable _scoreScriptable;

        private void Awake()
        {
            _scoreDisplay = GetComponent<TextMeshProUGUI>();
            OnScoreChanged();
        }

        public void OnScoreChanged() => _scoreDisplay.text = _scoreScriptable.Score.ToString();
    }
}

