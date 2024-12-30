using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pami1_elwin : MonoBehaviour
{

    Rigidbody rb;

    // Ficelle booléenne pour déclencher le mouvement
    private bool isMoving = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            transform.position += new Vector3(0.01f, 0, 0);
        }

        if (Input.GetKey(KeyCode.F))
        {
            isMoving = true;
        }
    }
}