using UnityEngine;

public class Fire : MonoBehaviour {
    [SerializeField] int damage = 1;

    private void Start() {
        Destroy(gameObject, 1);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (!CompareTag(other.gameObject.tag)) {
            other.gameObject.GetComponent<Health>().UpdateHealth(damage);
        }
    }
}
