using UnityEngine;

namespace Model
{
    public class GameSession : MonoBehaviour
    {
        [SerializeField] private ScoreData scoreData;
        [SerializeField] private PauseData pauseData;
        public ScoreData ScoreData => scoreData;
        public PauseData PauseData => pauseData;

        private void Awake()
        {
            if (IsSessionExit())
                DestroyImmediate(gameObject);
            else
                DontDestroyOnLoad(this);
        }

        private bool IsSessionExit()
        {
            var sessions = FindObjectsOfType<GameSession>();
            
            foreach (var gameSession in sessions)
                if (gameSession != this)
                    return true;

            return false;
        }
        
        public void SetDefoultValues()
        {
            scoreData.SetDefoultValues();
            pauseData.SetDefoultValues();
        }
    }
}