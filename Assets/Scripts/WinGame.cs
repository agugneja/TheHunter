using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    void winGame() {
        int powerCheck = PlayerPrefs.GetInt("PowerOn");
        if(powerCheck == 1) {
            Debug.Log("you won!");
        }
    }

    void Update() {
        winGame();
    }
}
