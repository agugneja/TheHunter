using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

   public Transform cameraPosition;

    private void Update() {
        //keeps camera on player
        transform.position = cameraPosition.position;
    }

}
