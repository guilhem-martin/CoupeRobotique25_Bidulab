using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotClt : MonoBehaviour
{


    public List<Wheel> wheels = new List<Wheel>();

    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!rb.isKinematic)
        {
            if (Input.GetKey(KeyCode.H))
            {
                transform.position += Vector3.up * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.L))
            {
                transform.position += Vector3.down * Time.deltaTime;
            }
        }
    }
}
