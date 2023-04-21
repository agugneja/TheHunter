using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public float maxHealth = 1f;
    public float currentHealth = 1f;
    bool canCauseDamage = true;

    private void OnTriggerStay(Collider other) {
        if(other.GetComponent<Collider>().gameObject.CompareTag("Mutant")) {
           StartCoroutine(Damage());
           Debug.Log(currentHealth);
        }
    }

    void checkDeath() {
        if(currentHealth <= 0.001f) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(3);
        }
    }

    void Update() {
        checkDeath();
    }

    IEnumerator Damage() 
    {
        if(canCauseDamage) {
            canCauseDamage = false;            
            currentHealth -= .2f;

            yield return new WaitForSeconds(2.7f);
            
            canCauseDamage = true;
        }
        


    }
}
