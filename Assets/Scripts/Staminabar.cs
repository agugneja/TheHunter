using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Staminabar : MonoBehaviour
{
    private static Image staminabar;

    void Start() {
        staminabar = GetComponent<Image>();
    }

    void Update() {
        GameObject player = GameObject.Find("Player");
        PlayerMovement playerMovement = player.GetComponent<PlayerMovement>();
        float stamina = playerMovement.stamina;
        float maxStamina = playerMovement.maxStamina;
        staminabar.fillAmount = stamina;

        if(stamina <= 0.25f) {
            staminabar.color = Color.red;
        }
        else {
            staminabar.color = Color.blue;
        }
    }
}
