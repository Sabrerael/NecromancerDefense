using UnityEngine;

public class ContactDamage : MonoBehaviour {
    [SerializeField] int damage = 1;
    [SerializeField] float damageInterval = 1;

    private bool contactStarted = false;
    private float timer = 0;
    private Health targetHealth;

    public void Update() {
        if (targetHealth == null) { return; }

        if (contactStarted) {
            if (timer >= damageInterval) {
                timer = 0;
                targetHealth.UpdateHealth(damage);
            }

            timer += Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (!CompareTag(collision.gameObject.tag)) {
            contactStarted = true;
            timer = 0;
            targetHealth = collision.gameObject.GetComponent<Health>();
        }
    }
}
