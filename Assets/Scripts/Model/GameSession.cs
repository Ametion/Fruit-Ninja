using UnityEngine;

namespace Model
{
    public class GameSession : MonoBehaviour
    {
        [SerializeField] private ScoreData scoreData;
        [SerializeField] private PauseData pauseData;
        public ScoreData ScoreData => scoreData;
        public PauseData PauseData => pauseData;

        private void Awake() => SetDefoultValues();

        private void SetDefoultValues()
        {
            scoreData.SetDefoultValues();
            pauseData.SetDefoultValues();
        }
    }
}