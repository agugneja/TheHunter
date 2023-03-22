using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth = 100;

    private void OnCollisionEnter(Collision other) {
        if(other.collider.gameObject.CompareTag("Mutant")) {
            currentHealth -= 20;
        }
    }
}
