using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{

    void OnTriggerStay(Collider other) {
        int powerCheck = PlayerPrefs.GetInt("PowerOn");
        if(powerCheck == 1 && other.gameObject.tag == "ExitFence") {
            SceneManager.LoadScene(2);
        }
    }
}
