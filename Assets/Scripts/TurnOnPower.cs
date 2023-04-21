using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnPower : MonoBehaviour
{
    void OnTriggerStay(Collider other) {
        //check if player has picked up both fuses/batteries
        int battery1Check = PlayerPrefs.GetInt("HasBattery1");
        int battery2Check = PlayerPrefs.GetInt("HasBattery2");
        //if player touches electrical panel
        if(battery1Check == 1 && battery2Check == 1 && other.gameObject.tag == "ElectricPanel" || other.gameObject.tag == "Player") {
            //complete puzzle
            PlayerPrefs.SetInt("PowerOn", 1);
            Debug.Log("Power On");
        }
    }
}
