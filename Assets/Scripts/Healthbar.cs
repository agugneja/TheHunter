using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    private static Image healthbar;

    void Start() {
        healthbar = GetComponent<Image>();
    }

    void Update() {
        GameObject player = GameObject.Find("Player");
        PlayerDamage playerDamage = player.GetComponent<PlayerDamage>();
        float currentHealth = playerDamage.currentHealth;
        float maxHealth = playerDamage.maxHealth;
        healthbar.fillAmount = currentHealth;

        if(currentHealth <= 0.5f) {
            healthbar.color = Color.red;
        }
        else {
            healthbar.color = Color.green;
        }
    }
    
}
