using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bras : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("bras script started");
    }

    // Update is called once per frame
    void Update()
    {
        // log message
        Debug.Log("Updating the arm");
        transform.Rotate(0, 0, 10);
    }
}
