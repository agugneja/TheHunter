using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{

    void OnTriggerStay(Collider other) {
        //if the power is on and player touches exit fence trigger game win
        int powerCheck = PlayerPrefs.GetInt("PowerOn");
        if(powerCheck == 1 && other.gameObject.tag == "ExitFence") {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(2);
        }
    }
}
