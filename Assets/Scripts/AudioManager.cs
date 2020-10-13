using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class AudioManager : MonoBehaviour {

    public Sound[] sounds;
    public static AudioManager instance;

    //[HideInInspector]
    //public bool sceneChange = true;

    // Use this for initialization
    private void Awake() {        
        // Check if there's existing AudioManager
        if (instance == null)
            instance = this;
        else {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        // Copying the sound refference into AudioManager
        foreach (Sound s in sounds) {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.playOnAwake = s.playOnAwake;
            s.source.loop = s.loop;
        }
	}

    private void Start() {
        Play("Theme");
    }

    public void Play(string name) {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) {
            Debug.Log("Sound '" + name + "' is not found!");
            return;
        }

        s.source.Play();
        Debug.Log("Sound '" + name + "' is playing!");
    }

    /**********************  NOT WORKING  **********************
    private void Update() {
        int scene = SceneManager.GetActiveScene().buildIndex;
        if (sceneChange == true) {
            foreach (Sound s in sounds)
                s.source.Stop();

            switch (scene) {
                case 0:
                    Play("Theme");
                    sceneChange = false;
                    break;
                case 1:
                    Play("Level1");
                    sceneChange = false;
                    break;
                case 2:
                    Play("Level2");
                    sceneChange = false;
                    break;
                case 3:
                    Play("Level3");
                    sceneChange = false;
                    break;
            }
        }
    }
    */
}
