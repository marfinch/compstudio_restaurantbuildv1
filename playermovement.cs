using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
    public float speed = 100f;
    Rigidbody rb;
    public float sensitivity;
    public float yRotSpeed = 10;
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        Vector2 xMov = new Vector2(Input.GetAxis("Horizontal") * transform.right.x, Input.GetAxisRaw("Horizontal") * transform.right.z);
        Vector2 zMov = new Vector2(Input.GetAxis("Vertical") * transform.forward.x, Input.GetAxisRaw("Vertical") * transform.forward.z);

        Vector2 velocity = (xMov + zMov).normalized * speed * Time.deltaTime;

        //Rotation
        float yRot = Input.GetAxisRaw("Mouse X") * sensitivity * yRotSpeed;
        rb.rotation *= Quaternion.Euler(0, yRot * Time.deltaTime, 0);

        float xRot = Input.GetAxisRaw("Mouse Y") * sensitivity;
        float x_cam_rot = cam.transform.eulerAngles.x;
        x_cam_rot -= xRot;

        float camEulerAnglesX = cam.transform.localEulerAngles.x;

        camEulerAnglesX -= xRot;

        cam.transform.localEulerAngles = new Vector3(camEulerAnglesX, 0, 0);

        rb.velocity = new Vector3(velocity.x, rb.velocity.y, velocity.y);
        
    }
}
