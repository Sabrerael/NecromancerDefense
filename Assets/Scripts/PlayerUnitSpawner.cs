using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerUnitSpawner : MonoBehaviour {
    [SerializeField] GameObject playerUnit;

    private int spawnResource = 500;

    private void Update() {

        if (spawnResource >= 50 && Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame) {
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

            if (worldPos.x < 0) {
                Vector3 spawnPoint = new Vector3(Mathf.RoundToInt(worldPos.x), Mathf.RoundToInt(worldPos.y));
                Instantiate(playerUnit, spawnPoint, Quaternion.identity);
                spawnResource -= 50;
            }
        }
    }
}
