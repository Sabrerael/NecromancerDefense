using UnityEngine;

public class Movement : MonoBehaviour {
    [SerializeField] float speed = 5;

    private float multiplier = 1;

    public void FixedUpdate() {
        transform.position = new Vector3(transform.position.x + (Time.fixedDeltaTime * speed * multiplier), transform.position.y);
    }

    public void SetMultiplier(float value) {
        multiplier = value;
    }
}
