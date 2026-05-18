using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
    public void LoadMainMenu() {
        SceneManager.LoadScene(0);
    }

    public void LoadGame() {
        SceneManager.LoadScene(1);
    }

    public void LoadGameOver() {
        SceneManager.LoadScene(2);
    }
}
