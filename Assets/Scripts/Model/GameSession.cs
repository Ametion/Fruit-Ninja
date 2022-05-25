using UnityEngine;

namespace Model
{
    public class GameSession : MonoBehaviour
    {
        [SerializeField] private ScoreData _scoreData;
        [SerializeField] private PauseData _pauseData;
        public ScoreData ScoreData => _scoreData;
        public PauseData PauseData => _pauseData;

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
    }
}