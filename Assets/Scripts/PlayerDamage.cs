using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public float maxHealth = 1f;
    public float currentHealth = 1f;

    private void OnCollisionEnter(Collision other) {
        if(other.collider.gameObject.CompareTag("Mutant")) {
           currentHealth -= .2f;
        }
    }

    void checkDeath() {
        if(currentHealth <= 0) {
            SceneManager.LoadScene(3);
        }
    }

    void Update() {
        checkDeath();
    }
}
