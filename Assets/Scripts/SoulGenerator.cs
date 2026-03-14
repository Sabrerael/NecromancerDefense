using UnityEngine;

public class SoulGenerator : MonoBehaviour {
    private int soulAmount = 10;
    private float resourceTime = 5;
    private float timer = 0;

    private void Update() {
        if (timer >= resourceTime) {
            PlayerUnitSpawner.instance.UpdateSpawnResource(soulAmount);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
