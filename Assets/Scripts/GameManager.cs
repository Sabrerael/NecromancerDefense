using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    [SerializeField] int healthPoints = 1;

    private void Awake() {
        instance = this;
    }

    public void LoseHealth() {
        healthPoints--;
        if (healthPoints >= 0)
        {
            FindFirstObjectByType<LevelLoader>().LoadGameOver();
        }
    }
}
