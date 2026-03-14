using UnityEngine;

public class SpellLauncher : MonoBehaviour {
    [SerializeField] GameObject spellPrefab;

    private int spellResource = 0;
    private float resourceTime = 5;
    private float timer = 0;

    private void Start() {
        UIManager.instance.UpdateSpellResource(spellResource);
    }

    private void Update() {
        if (timer >= resourceTime) {
            UpdateSpellResource(25);
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    public int GetSpellResource() {
        return spellResource;
    }

    public void UpdateSpellResource(int value) {
        spellResource = Mathf.Max(spellResource + value, 0);
        UIManager.instance.UpdateSpellResource(spellResource);
    }

    public void LaunchSpell(Vector3 worldPos) {
        if (spellResource < 50) {
            Debug.Log("Insufficent Resources");
            return;
        }

        if (worldPos.x < 0) {
            Vector3 spawnPoint = new Vector3(0, Mathf.RoundToInt(worldPos.y));
            Instantiate(spellPrefab, spawnPoint, Quaternion.identity);
            UpdateSpellResource(-50);
        }
    }
}
