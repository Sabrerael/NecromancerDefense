using UnityEngine;

public class Archer : MonoBehaviour {
    [SerializeField] GameObject arrowPrefab;
    [SerializeField] float arrowTime = 2f;

    private float timer = 0;

    private void Update() {
        if (timer >= arrowTime) {
            Instantiate(arrowPrefab, transform.position, Quaternion.identity);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
