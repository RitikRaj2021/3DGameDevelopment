using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseLookMovemnt : MonoBehaviour
{
    public float sensitivity = 100.0f; // mouse sensitivity

    float rotationX;
    float rotationY;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
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
}
