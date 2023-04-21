using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour {
    public float sensX; //x sensitivity
    public float sensY; //y sensitivity

    public Transform orientation;

    float xRotation;
    float yRotation;

    private void Start() {
        ResetPuzzles();
        Cursor.lockState = CursorLockMode.Locked; //locks cursor to middle of screen
        Cursor.visible = false; //makes cursor invisible
    }

    private void Update() {
        //controls players look direction
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX; //get x mouse input
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY; //get y mouse input

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }

    public void ResetPuzzles() {
        PlayerPrefs.SetInt("HasKey1", 0);
        PlayerPrefs.SetInt("HasKey2", 0);
        PlayerPrefs.SetInt("HasBattery1", 0);
        PlayerPrefs.SetInt("HasBattery2", 0);
        PlayerPrefs.SetInt("PowerOn", 0);
    }
}
