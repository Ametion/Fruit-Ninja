using UnityEngine;
using UnityEngine.UI;

namespace Model
{
    [System.Serializable]
    public class ScoreData
    {
        [SerializeField] private Text scoreText;
        
        private int _score;

        public void ModifyScore(int modifiedScore)
        {
            _score += modifiedScore;
            scoreText.text = _score.ToString();
        }

        public void SetDefoultValues() => _score = 0;
    }
}