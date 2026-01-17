using UnityEngine;

public class Movement : MonoBehaviour {
    [SerializeField] float speed = 5;

    public void FixedUpdate() {
        transform.position = new Vector3(transform.position.x + (Time.fixedDeltaTime * speed), transform.position.y);
    }
}
