using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private float moveSpeed;
    public float walkSpeed;
    public float sprintSpeed;

    public Transform orientation;

    float xInput;
    float yInput;

    Vector3 moveDirection;

    Rigidbody rb;

    public float groundDrag;
    public float playerHeight;
    public LayerMask ground;
    bool grounded;

    public KeyCode sprintKey = KeyCode.LeftShift;
    public MovementState state;

    public float maxStamina;
    public float stamina;

    public enum MovementState {
        walking,
        sprinting
    }

    private void Start() {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update() {
        //applies drag to movement
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, ground);
        KeyInput();

        if(grounded) { 
            rb.drag = groundDrag; 
        }
        else {
            rb.drag = 0;
        }

        SpeedControl();
        StateHandler();
    }

    private void FixedUpdate() {
        PlayerMove();
    }

    private void StateHandler() {
        //allows player to sprint if they have stamina
        if(Input.GetKey(sprintKey) && stamina > 0) {
            state = MovementState.sprinting;
            moveSpeed = sprintSpeed;
            stamina = Mathf.Clamp(stamina - (.2f * Time.deltaTime), 0f, maxStamina);
        }
        else {
            //else walk
            state = MovementState.walking;
            moveSpeed = walkSpeed;
            if(stamina < maxStamina) {
                stamina = Mathf.Clamp(stamina + (.3f * Time.deltaTime), 0f, maxStamina);
            }

        }
    }

    private void KeyInput() {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
    }

    private void PlayerMove() {
        //moves player in direction based on key input
        moveDirection = orientation.forward * yInput + orientation.right * xInput;
        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }

    private void SpeedControl() {
        //limits velocity if greater than moveSpeed
        Vector3 flatVelocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if(flatVelocity.magnitude > moveSpeed) {
            Vector3 limitedVelocity = flatVelocity.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVelocity.x, rb.velocity.y, limitedVelocity.z);
        }
        
    }
}
