using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_principal : MonoBehaviour
{

    Rigidbody rb;

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
            if (!rb.isKinematic) {
                Debug.Log("Adding force to the robot");
                rb.AddForce(transform.forward * 10);
                transform.position += new Vector3(0, 0, 0.01f);
            }
        }
    }
}
