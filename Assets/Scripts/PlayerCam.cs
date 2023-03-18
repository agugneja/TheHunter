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
        Cursor.lockState = CursorLockMode.Locked; //locks cursor to middle of screen
        Cursor.visible = false; //makes cursor invisible
    }

    private void Update() {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX; //get x mouse input
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY; //get y mouse input

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
