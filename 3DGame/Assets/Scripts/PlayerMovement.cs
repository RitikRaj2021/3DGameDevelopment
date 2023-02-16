using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6.0f; // player's movement speed


    public float sensitivity = 100.0f; // mouse sensitivity

    float rotationX;
    float rotationY;


    public Animator anim;


    // player's jump speed
    public float jumpSpeed = 8.0f;
    // strength of gravity
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;


    CharacterController charController;

    void Start()
    {
        charController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Player_Jump();


    }

    void FixedUpdate()
    {
        Player_WASD();
        Player_CursorLook();
    }

    private void Player_CursorLook()
    {
        // Get mouse input on the horizontal axis
        rotationX += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        // Get mouse input on the vertical axis
        rotationY -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Limit the vertical rotation to avoid flipping
        rotationY = Mathf.Clamp(rotationY, -89, 89);

        // Apply the rotations to the player's camera
        transform.localRotation = Quaternion.Euler(rotationY, rotationX, 0);

    }
    private void Player_WASD()
    {
        // Get horizontal and vertical inputs from the user
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calculate the direction of movement
        Vector3 moveDirection = new Vector3(horizontal, 0, vertical);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        // Apply the movement to the player's character controller
        charController.Move(moveDirection * Time.deltaTime);
    }

    private void Player_Jump()
    {
        // Check if the player is on the ground
        if (charController.isGrounded)
        {
            // Get vertical input from the user-
            float vertical = Input.GetAxis("Jump");

            // Check if the user pressed the jump button
            if (vertical > 0)
            {
                // Add jump force to the player's move direction
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity to the player's move direction
        moveDirection.y -= gravity * Time.deltaTime;

        // Apply the movement to the player's character controller
        charController.Move(moveDirection * Time.deltaTime);
    }

}
