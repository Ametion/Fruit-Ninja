using System;
using System.Collections;
using Model;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Scripts
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private int _spawnTime;

        private GameSession gameSession;

        private void Awake() => gameSession = FindObjectOfType<GameSession>();

        private IEnumerator Start()
        {
            while (true)
            {
                if (!gameSession.PauseData.IsPause)
                {
                    Instantiate(_prefab, new Vector3(Random.Range(-9, 9), -6, 0), Quaternion.identity);
                    yield return new WaitForSeconds(_spawnTime);
                }
                else
                    yield return null;
            }
        }
    }
}