using UnityEngine;

public class Health : MonoBehaviour {
    [SerializeField] int totalHealthPoints = 5;

    [SerializeField] private int currentHealth;

    private void Awake() {
        currentHealth = totalHealthPoints;
    }

    public void UpdateHealth(int healthChange) {
        currentHealth -= healthChange;

        if (currentHealth <= 0)
            Die();
    }

    private void Die() {
        if (CompareTag("Enemy")) {
            PlayerUnitSpawner.instance.UpdateSpawnResource(25);
        }
        Destroy(gameObject);
    }
}
