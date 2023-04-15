using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnPower : MonoBehaviour
{
    void OnTriggerStay(Collider other) {
        int battery1Check = PlayerPrefs.GetInt("HasBattery1");
        int battery2Check = PlayerPrefs.GetInt("HasBattery2");
        if(battery1Check == 1 && battery2Check == 1 && other.gameObject.tag == "electricPanel" || other.gameObject.tag == "Player") {
            PlayerPrefs.SetInt("PowerOn", 1);
            Debug.Log("Power On");
        }
    }
}
