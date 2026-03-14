using UnityEngine;

public class PlayerUnitSpawner : MonoBehaviour {
    [SerializeField] GameObject playerUnit;

    private int spawnResource = 500;

    private float resourceTime = 5;
    private float timer = 0;

    private void Start() {
        UIManager.instance.UpdateResource(spawnResource);
    }

    private void Update() {
        if (timer >= resourceTime) {
            UpdateSpawnResource(25);
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    public int GetSpawnResource() {
        return spawnResource;
    }

    public void UpdateSpawnResource(int value) {
        spawnResource = Mathf.Max(spawnResource + value, 0);
        UIManager.instance.UpdateResource(spawnResource);
    }

    public void SpawnUnit(Vector3 worldPos) {
        if (spawnResource < 50) {
            Debug.Log("Insufficent Resources");
            return;
        }

        if (worldPos.x < 0) {
            Vector3 spawnPoint = new Vector3(Mathf.RoundToInt(worldPos.x), Mathf.RoundToInt(worldPos.y));
            Instantiate(playerUnit, spawnPoint, Quaternion.identity);
            UpdateSpawnResource(-50);
        }
    }
}
