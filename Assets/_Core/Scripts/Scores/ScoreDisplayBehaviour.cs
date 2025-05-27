using TMPro;
using UnityEngine;

namespace Pong.Scores 
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ScoreDisplayBehaviour : MonoBehaviour
    {
        private TextMeshProUGUI _scoreDisplay;
        [SerializeField] private ScoreData _scoreScriptable;

        private void Awake()
        {
            _scoreDisplay = GetComponent<TextMeshProUGUI>();
            RefreshDisplayScore();
        }

        public void RefreshDisplayScore() => _scoreDisplay.text = _scoreScriptable.Score.ToString();
    }
}

