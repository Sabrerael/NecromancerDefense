using UnityEngine;

public class SpawnerController : MonoBehaviour {
    [SerializeField] EnemySpawner[] spawners;
    [SerializeField] SpawnInfoSO spawnInfo;

    private float spawnTime;
    private float timer = 0;
    private int enemyCount;
    private int enemiesSpawned = 0;

    public void Awake() {
        spawnTime = spawnInfo.GetInitialWait() + spawnInfo.GetSpawnDelay(enemiesSpawned);
        enemyCount = spawnInfo.GetEnemyCount();
        Debug.Log("Spawn Timer: " + spawnTime);
    }

    public void Update() {
        if (enemiesSpawned >= enemyCount) { 
            Debug.Log("All enemies spawned");
            return;
        }
        if (timer >= spawnTime) {
            spawners[Random.Range(0, spawners.Length)].SpawnEnemy(spawnInfo.GetEnemyPrefab(enemiesSpawned));
            enemiesSpawned++;

            spawnTime = spawnInfo.GetSpawnDelay(enemiesSpawned);
            Debug.Log("Spawn Timer: " + spawnTime);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
