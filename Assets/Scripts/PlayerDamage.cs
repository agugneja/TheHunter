using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public float maxHealth = 1f;
    public float currentHealth = 1f;
    bool canCauseDamage = true;
    AudioSource source;

    private void OnTriggerStay(Collider other) {
        if(other.GetComponent<Collider>().gameObject.CompareTag("Mutant")) {
           StartCoroutine(Damage());
        }
    }

    void checkDeath() {
        //check if health is close to 0
        if(currentHealth <= 0.001f) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            //trigger lose screen
            SceneManager.LoadScene(3);
        }
    }

    void Update() {
        checkDeath();
    }

    void Start() {
        source = GetComponent<AudioSource>();
    }

    IEnumerator Damage() {
        //allows damage to be done every 2.7 seconds (length of animation)
        if(canCauseDamage) {
            canCauseDamage = false;
            source.Play();
            currentHealth -= .2f;

            yield return new WaitForSeconds(2.7f);
            
            canCauseDamage = true;
        }
        


    }
}
