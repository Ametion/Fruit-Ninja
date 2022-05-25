using UnityEngine;
using UnityEngine.UI;

namespace Model
{
    [System.Serializable]
    public class ScoreData
    {
        [SerializeField] private Text _scoreText;

        private int score;

        public void ModifyScore(int modifiedScore)
        {
            score += modifiedScore;
            _scoreText.text = score.ToString();
        }
    }
}