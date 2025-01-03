using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roue_pami1 : MonoBehaviour
{

    private bool isMoving = false;


    public void Move(bool moving)
    {
        isMoving = moving;
        // print debug message "coucou Elwin"
        Debug.Log("coucou Elwin");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // this wheel shows rotation
        if (isMoving)
            transform.Rotate(0, 0, 10);

    }
}
