using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
    GameObject [] locks;

    void OnTriggerStay(Collider other) {
    int key1Check = PlayerPrefs.GetInt("HasKey1");
    int key2Check = PlayerPrefs.GetInt("HasKey2");
    if(key1Check == 1 && key2Check == 1 && other.gameObject.tag == "Player" && gameObject.tag == "FenceGate") {
        locks = GameObject.FindGameObjectsWithTag("Lock");
            foreach(GameObject l in locks) {
                l.SetActive(false);
            }
            gameObject.SetActive(false);
    }
   }
    //debug logging
//     void Update() {
//         Debug.Log("k1: " + PlayerPrefs.GetInt("HasKey1"));
//         Debug.Log("k2: " + PlayerPrefs.GetInt("HasKey2"));
//    }
}
