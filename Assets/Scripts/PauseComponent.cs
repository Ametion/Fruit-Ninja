using System;
using Model;
using UnityEngine;

public class PauseComponent : MonoBehaviour
{
    private GameSession gameSession;

    private void Awake() => gameSession = FindObjectOfType<GameSession>();

    public void Pause() => gameSession.PauseData.IsPause = true;
    
    public void Resume() => gameSession.PauseData.IsPause = false;
}