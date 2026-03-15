using UnityEngine;

public class SpellLauncher : MonoBehaviour {
    [SerializeField] GameObject spellPrefab;
    [SerializeField] GameObject thunderPrefab;
    [SerializeField] GameObject blizzardPrefab;

    private int spellResource = 10000;
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
        if (spellResource < 100) {
            Debug.Log("Insufficent Resources");
            return;
        }


            Vector3 spawnPoint = new Vector3(0, Mathf.RoundToInt(worldPos.y));
            Instantiate(spellPrefab, spawnPoint, Quaternion.identity);
            UpdateSpellResource(-100);
 
    }

    public void LaunchThunderSpell(Vector3 worldPos) {
        if (spellResource < 50) {
            Debug.Log("Insufficent Resources");
            return;
        }


            Vector3 spawnPoint = new Vector3( Mathf.RoundToInt(worldPos.x), Mathf.RoundToInt(worldPos.y));
            Instantiate(thunderPrefab, spawnPoint, Quaternion.identity);
            UpdateSpellResource(-50);

    }

    public void LaunchBlizzardSpell(Vector3 worldPos) {
        if (spellResource < 75) {
            Debug.Log("Insufficent Resources");
            return;
        }


            Vector3 spawnPoint = new Vector3( Mathf.RoundToInt(worldPos.x), Mathf.RoundToInt(worldPos.y));
            Instantiate(blizzardPrefab, spawnPoint, Quaternion.identity);
            UpdateSpellResource(-75);

    }
}
