using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject player;

    public float movementSpeed;
    public float rotationSpeed;
    Rigidbody rb;

    [SerializeField] private float horizontalMouseSensitivity = 0.5f;
    [SerializeField] private float verticalMouseSensitivity = 0.5f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //mouseLook();

        transform.Rotate(0, Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime, 0);

        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed, 0, 0);

        //if(Input.GetKey(KeyCode.W))
        //{
        //    rb.velocity = new Vector3(0, 0, 1) * movementSpeed;
        //}
        //if(Input.GetKey(KeyCode.S))
        //{
        //    rb.velocity = new Vector3(0, 0, -1) * movementSpeed;
        //}
        //if(Input.GetKey(KeyCode.A))
        //{
        //    rb.velocity = -transform.right * movementSpeed;
        //}
        //if(Input.GetKey(KeyCode.D))
        //{
        //    rb.velocity = transform.right * movementSpeed;
        //}

    }

    void mouseLook()
    {
        float deltaMouseHorizontal = Input.GetAxis("Mouse X") * horizontalMouseSensitivity;
        float deltaMouseVertical = Input.GetAxis("Mouse Y") * verticalMouseSensitivity;
        float newCameraRotY = transform.eulerAngles.y + deltaMouseHorizontal;
        float newCameraRotX = transform.eulerAngles.x - deltaMouseVertical;

        transform.eulerAngles = new Vector3(newCameraRotX, newCameraRotY, 0);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }


}
