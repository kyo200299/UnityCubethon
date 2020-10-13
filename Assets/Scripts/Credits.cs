using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

    public void mainMenu() {
        Debug.Log("Back to Main Menu!");
        FindObjectOfType<AudioManager>().Play("Button");
        SceneManager.LoadScene(0);
    }

}
