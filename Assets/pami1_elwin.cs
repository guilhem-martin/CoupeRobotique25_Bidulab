using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pami1_elwin : MonoBehaviour
{

    Rigidbody rb;

    // Ficelle booléenne pour déclencher le mouvement
    private bool isMoving = false;

    public float moveSpeed = 0.01f;


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
            // D'abord, l'objet se déplace tout droit vers la scène
            transform.position += new Vector3(0, 0, moveSpeed);
            // Il le fait pendant 1.25 secondes
        }

        if (Input.GetKey(KeyCode.F))
        {
            isMoving = true;
        }
    }
}