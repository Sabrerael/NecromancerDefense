using UnityEngine;

public class Arrow : MonoBehaviour {
    [SerializeField] float speed = 2f;
    [SerializeField] int damage = 2;

    private void Update() {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (!CompareTag(other.gameObject.tag)) {
            other.gameObject.GetComponent<Health>().UpdateHealth(damage);
            Destroy(gameObject);
        }
    }
}
