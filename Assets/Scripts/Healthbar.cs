using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    private static Image healthbar;

    void Start() {
        //get healthbar from unity
        healthbar = GetComponent<Image>();
    }

    void Update() {
        //get player health
        GameObject player = GameObject.Find("Player");
        PlayerDamage playerDamage = player.GetComponent<PlayerDamage>();

        float currentHealth = playerDamage.currentHealth;
        float maxHealth = playerDamage.maxHealth;
        //set fillAmount of healthbar to current health
        healthbar.fillAmount = currentHealth;

        //if health above 50% healthbar is green
        if(currentHealth <= 0.5f) {
            healthbar.color = Color.red;
        }
        //else it's red
        else {
            healthbar.color = Color.green;
        }
    }
    
}
