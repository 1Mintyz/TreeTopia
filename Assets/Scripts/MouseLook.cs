using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitvity = 100f;
    public Transform playerBody;
    public float xRoatation = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")* mouseSensitvity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitvity * Time.deltaTime;
            playerBody.Rotate(Vector3.up * mouseX);
        xRoatation -= mouseY;
        xRoatation = Mathf.Clamp(xRoatation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(xRoatation, 0f, 0f);
    }
}