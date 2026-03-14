using UnityEngine;

public class KillBox : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(other.gameObject);
    }
}
