using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    public void loadNextLevel() {
        Debug.Log("Loading the next level");
        // Loading the next scene by the build index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //FindObjectOfType<AudioManager>().sceneChange = true;
    }

}
