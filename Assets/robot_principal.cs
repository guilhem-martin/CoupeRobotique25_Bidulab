using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_principal : MonoBehaviour
{

    Rigidbody rb;

    // private Vector2 robotSpeed = new Vector2(0f, 0f); // m/s
    // private float angularSpeed = 0f; // t/s
    // public float speed = 0.5f;
    // public float angSpeed = 0.5f;
    // public SerialCommunication comm;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // When clicking on h, the robot moves forward
        if (Input.GetKey(KeyCode.H))
        {
            // add log message
            Debug.Log("H key was pressed");
            if (!rb.isKinematic)
            {
                Debug.Log("Adding force to the robot");
                rb.AddForce(transform.forward * 10);
                transform.position += new Vector3(0, 0, 0.01f);
            }
        }
    }

    // private void FixedUpdate()
    // {
    //     if (!rb.isKinematic)
    //     {
    //         // Ensure SerialCommunication component is assigned
    //         if (comm == null)
    //         {
    //             Debug.LogError("SerialCommunication component is not assigned.");
    //         }
    //         else
    //         {
    //             angularSpeed = comm.keys.Joystick2_X * angSpeed;
    //             robotSpeed.y = comm.keys.Joystick1_Y;
    //             robotSpeed.x = comm.keys.Joystick1_X;
    //             float sped = Mathf.Clamp01(robotSpeed.sqrMagnitude) * speed;
    //             float ang = Mathf.Atan2(robotSpeed.y, robotSpeed.x);

    //             //rb.velocity = sped * (transform.right * Mathf.Cos(ang) + transform.forward * Mathf.Sin(ang));
    //             //rb.angularVelocity = Vector3.up * angularSpeed * 2 * Mathf.PI;
    //             rb.AddForce(sped * (transform.right * Mathf.Cos(ang) + transform.forward * Mathf.Sin(ang)), ForceMode.Force);
    //             rb.angularVelocity = 2 * angularSpeed * Mathf.PI * Vector3.up;
    //         }
    //     }
    // }
}
