using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour {
    [SerializeField] GameObject flashlight;
    private bool flashlightIsOn = false;

    void Start() {
        //flashlight starts off
        flashlight.gameObject.SetActive(false);
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.F)) {
            if(flashlightIsOn == false) {
                flashlight.gameObject.SetActive(true);
                flashlightIsOn = true;
            }
            else {
                flashlight.gameObject.SetActive(false);
                flashlightIsOn = false;
            }
        }
    }
}
