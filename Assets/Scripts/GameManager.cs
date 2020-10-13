using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 3f;
    public GameObject completeLevelUI;

    public void endGame() {
        if (gameHasEnded == false) {
            Debug.Log("Game Over!");
            gameHasEnded = true;
            // Invoke after delay
            Invoke("restart", restartDelay);
        }
    }

    public void completeLevel() {
        Debug.Log("Level Completed!");
        // Bring in the level complete animation and load the next level
        completeLevelUI.SetActive(true);
        FindObjectOfType<AudioManager>().Play("LevelComplete");
    }

    void restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
