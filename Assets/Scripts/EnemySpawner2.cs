using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner2 : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;
    public float spawnInterval = 20f;
    public float enemyLifeTime = 5f;
    public float initialSpawnDistance = 10f;
    public float spawnDistanceDecrease = 1f;

    private float currentSpawnDistance;

    void Start()
    {
        currentSpawnDistance = initialSpawnDistance;
        StartCoroutine(SpawnEnemyRoutine());
    }

    IEnumerator SpawnEnemyRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            Vector3 spawnPosition = player.position + player.forward * currentSpawnDistance;
            GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
            StartCoroutine(DestroyEnemyRoutine(enemy));
            currentSpawnDistance = Mathf.Max(0.5f, currentSpawnDistance - spawnDistanceDecrease);
        }
    }

    IEnumerator DestroyEnemyRoutine(GameObject enemy)
    {
        yield return new WaitForSeconds(enemyLifeTime);
        if (enemy != null)
        {
            Destroy(enemy);
        }
    }
}
