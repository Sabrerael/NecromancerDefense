using UnityEngine;

public class PlayerUnitSpawner : MonoBehaviour {
    public static PlayerUnitSpawner instance;

    [SerializeField] GameObject playerUnit;
    [SerializeField] GameObject soulGenerator;

    private int spawnResource = 500;

    private void Awake() {
        instance = this;
    }

    private void Start() {
        UIManager.instance.UpdateResource(spawnResource);
    }

    public int GetSpawnResource() {
        return spawnResource;
    }

    public void UpdateSpawnResource(int value) {
        spawnResource = Mathf.Max(spawnResource + value, 0);
        UIManager.instance.UpdateResource(spawnResource);
    }

    public void SpawnUnit(Vector3 worldPos) {
        if (spawnResource < 100) {
            Debug.Log("Insufficent Resources");
            return;
        }

        if (worldPos.x < 0) {
            Vector3 spawnPoint = new Vector3(Mathf.RoundToInt(worldPos.x), Mathf.RoundToInt(worldPos.y));
            Instantiate(playerUnit, spawnPoint, Quaternion.identity);
            UpdateSpawnResource(-100);
        }
    }

    public void SpawnSoulGenerator(Vector3 worldPos) {
        if (spawnResource < 50) {
            Debug.Log("Insufficent Resources");
            return;
        }

        if (worldPos.x < 0) {
            Vector3 spawnPoint = new Vector3(Mathf.RoundToInt(worldPos.x), Mathf.RoundToInt(worldPos.y));
            Instantiate(soulGenerator, spawnPoint, Quaternion.identity);
            UpdateSpawnResource(-50);
        }
    }
}
