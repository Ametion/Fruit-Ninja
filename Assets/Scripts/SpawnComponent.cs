using System.Collections;
using UnityEngine;

public class SpawnComponent : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform position;
    [SerializeField] private Transform parent;
    
    [SerializeField] private bool foodSpawner;
    [SerializeField] private float spawnTime;

    private void Awake()
    {
        if (foodSpawner)
            StartCoroutine(FoodSpawner());
    }
    
    public void SpawnInParent() => Instantiate(prefab, parent);

    private IEnumerator FoodSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            Instantiate(prefab, new Vector3(Random.Range(-9, 9), -6, 0), Quaternion.identity);
        }
    }
}