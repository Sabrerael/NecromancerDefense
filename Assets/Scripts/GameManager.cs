using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    [SerializeField] int healthPoints = 5;

    private void Awake() {
        instance = this;
    }

    public void LoseHealth() {
        healthPoints--;
        if (healthPoints >= 0)
        {
            Debug.Log("You've lost!");
        }
    }
}
