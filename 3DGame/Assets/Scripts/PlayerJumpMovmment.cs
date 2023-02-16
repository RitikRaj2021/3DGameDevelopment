using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpMovmment : MonoBehaviour
{
    public float jumpSpeed = 8.0f; // player's jump speed
    public float gravity = 20.0f; // strength of gravity

    private Vector3 moveDirection = Vector3.zero;

    CharacterController charController;

    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    void Update()
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
