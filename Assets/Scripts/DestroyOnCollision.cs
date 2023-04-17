using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    void OnTriggerStay(Collider other) {
        //on player collision w/ key will set it to inactive and "pick" it up
        if(other.gameObject.tag == "Player" && gameObject.tag == "Key1") {
            PlayerPrefs.SetInt("HasKey1", 1);
            gameObject.SetActive(false);
        }

        else if(other.gameObject.tag == "Player" && gameObject.tag == "Key2") {
           PlayerPrefs.SetInt("HasKey2", 1);
            gameObject.SetActive(false);
        }

        else if(other.gameObject.tag == "Player" && gameObject.tag == "Battery1") {
            PlayerPrefs.SetInt("HasBattery1", 1);
            gameObject.SetActive(false);
        }

        else if(other.gameObject.tag == "Player" && gameObject.tag == "Battery2") {
            PlayerPrefs.SetInt("HasBattery2", 1);
            gameObject.SetActive(false);
        }

    }
}
