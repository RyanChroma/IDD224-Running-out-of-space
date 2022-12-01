using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationSpeed = 0f;
    public float mouseSensitivity = 0f;

    public Transform playerBody;

    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //WASD CAMERA MOVEMENT
        /*if(Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(-rotationSpeed, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -rotationSpeed, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(rotationSpeed, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);
        }*/

        //CAMERA MOUSE LOOK
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}