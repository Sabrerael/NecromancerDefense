using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    [SerializeField] GameObject enemyPrefab;

    public void SpawnEnemy(GameObject gameObject) {
        Instantiate(gameObject, transform.position, Quaternion.identity);
    }
}
