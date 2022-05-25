using System;
using Model;
using UnityEngine;

public class SpawnComponent : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform position;
    [SerializeField] private Transform parent;

    private GameSession gameSession;

    private void Awake() => gameSession = FindObjectOfType<GameSession>();

    public void SpawnInParent()
    {
        if(!gameSession.PauseData.IsPause)
            Instantiate(prefab, parent);
    }
}