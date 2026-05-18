using UnityEngine;

public class KillBox : MonoBehaviour {
    [SerializeField] bool playerSide = false;

    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(other.gameObject);
        if (playerSide) {
            GameManager.instance.LoseHealth();
        }
    }
}
