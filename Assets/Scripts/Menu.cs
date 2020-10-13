using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void startGame() {
        Debug.Log("Game Starts!");
        FindObjectOfType<AudioManager>().Play("GameStart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //FindObjectOfType<AudioManager>().sceneChange = true;
    }

    public void showCredits() {
        Debug.Log("Show Credits!");
        FindObjectOfType<AudioManager>().Play("Button");
        SceneManager.LoadScene("Credits");
    }
}
