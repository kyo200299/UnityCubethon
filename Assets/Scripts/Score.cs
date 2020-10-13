﻿using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    
	// Update is called once per frame
	void Update () {
        if (player.position.z < 1605) {
            scoreText.text = player.position.z.ToString("0" + "m");
        }
    }
}
