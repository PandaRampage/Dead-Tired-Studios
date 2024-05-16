using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class Cameracontroler : MonoBehaviour
{
    // Start is called before the first frame update
    private float mouseX,mouseY;
    public float mouseSensitivity;
    public Transform player;
    public float XRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        player.Rotate(Vector3.up * mouseX);
        XRotation -= mouseY;
        XRotation = Mathf.Clamp(XRotation, -90,90);
        transform.localRotation = Quaternion.Euler(XRotation, 0, 0);
    }
}
