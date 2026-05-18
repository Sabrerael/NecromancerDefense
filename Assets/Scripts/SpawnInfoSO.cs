using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnInfoSO", menuName = "Scriptable Objects/Spawn Info")]
public class SpawnInfoSO : ScriptableObject {
    [SerializeField] float initialWait = 5f;
    [SerializeField] List<GameObject> enemyPrefabs;
    [SerializeField] List<float> spawnDelays;

    public float GetInitialWait() { return initialWait; }
    public int GetEnemyCount() { return enemyPrefabs.Count; }
    public GameObject GetEnemyPrefab(int index) { return enemyPrefabs[index]; }
    public float GetSpawnDelay(int index) { return spawnDelays[index]; }
}
