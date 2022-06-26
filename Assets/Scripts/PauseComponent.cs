using Model;
using UnityEngine;

public class PauseComponent : MonoBehaviour
{
    private GameSession _gameSession;

    private void Awake() => _gameSession = FindObjectOfType<GameSession>();

    public void Pause() => _gameSession.PauseData.IsPause = true;
    
    public void Resume() => _gameSession.PauseData.IsPause = false;
}