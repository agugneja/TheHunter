using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
    GameObject [] locks;

    void OnTriggerStay(Collider other) {
        //if player has picked up both keys
        int key1Check = PlayerPrefs.GetInt("HasKey1");
        int key2Check = PlayerPrefs.GetInt("HasKey2");
        if(key1Check == 1 && key2Check == 1 && other.gameObject.tag == "Player" && gameObject.tag == "FenceGate") {
            //if player is touching gate
            locks = GameObject.FindGameObjectsWithTag("Lock");
            //"unlock" gate and progress in game
                foreach(GameObject l in locks) {
                    l.SetActive(false);
                }
                gameObject.SetActive(false);
        }
   }
}
