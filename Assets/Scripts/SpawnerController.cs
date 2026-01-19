using UnityEngine;

public class SpawnerController : MonoBehaviour {
    [SerializeField] EnemySpawner[] spawners;
    [SerializeField] float minimumSpawnTime = 1;
    [SerializeField] float maximumSpawnTime = 2;

    private float spawnTime;
    private float timer = 0;

    public void Start() {
        spawnTime = Random.Range(minimumSpawnTime, maximumSpawnTime);
        Debug.Log("Spawn Timer: " + spawnTime);
    }

    public void Update() {

    
        if (timer >= spawnTime) {
            spawners[Random.Range(0, spawners.Length)].SpawnEnemy();
            spawnTime = Random.Range(minimumSpawnTime, maximumSpawnTime);
            Debug.Log("Spawn Timer: " + spawnTime);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
