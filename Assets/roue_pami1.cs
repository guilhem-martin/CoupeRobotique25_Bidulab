using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roue_pami1 : MonoBehaviour
{

    private bool isMoving = false;


    public void Move(bool moving)
    {
        isMoving = moving;

        // Display the name of the parent
        Transform parent = transform.parent;

        // declare variable parent_name
        string parent_name;

         // retrieve the name of the parent if it's not null
        if (parent != null)
        {
            parent_name = parent.name;
        }
        else
        {
            parent_name = "null";
        }
        if (moving)
            Debug.Log("start wheeling on " + parent_name);
        else
            Debug.Log("stop wheeling on " + parent_name);
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
