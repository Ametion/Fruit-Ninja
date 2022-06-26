using System;
using Model;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneComponent : MonoBehaviour
{

    private GameSession _gameSession;

    private void Awake() => _gameSession = FindObjectOfType<GameSession>();

    public void LoadScene(int sceneId)
    {
        _gameSession.SetDefoultValues();
        SceneManager.LoadScene(sceneId);
    }

    public void ReloadScene() 
    {
        _gameSession.SetDefoultValues();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}