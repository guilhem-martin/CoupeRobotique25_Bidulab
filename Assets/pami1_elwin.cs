using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pami1_elwin : MonoBehaviour
{
    Rigidbody rb;
    roue_pami1 roueScript1;
    roue_pami1 roueScript2;

    // Ficelle booléenne pour déclencher le mouvement
    private bool isMoving = false;

    public float moveSpeed = 0.01f;

    private float timer = 0.0f;

    // Premier mouvement de l'objet pendant 1.25 secondes
    private float waitTime1 = 1.25f;

    // Deuxième mouvement de l'objet pendant 2 secondes
    private float waitTime2 = 0.9f;

    // Troisième mouvement de l'objet pendant 0.35 secondes
    private float waitTime3 = 0.35f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Display all children of the GameObject
        foreach (Transform child in transform)
        {
            Debug.Log($"child: {child}");

            // si c'est "roue 2" affiche les enfants de "roue 2"
            if (child.name == "roue 2")
            {
                foreach (Transform child2 in child)
                {
                    Debug.Log($"child2: {child2}");
                    // récupère le script roue_pami1 de "Inner-Node-roue2"
                    if (child2.name == "Inner-Node-roue2")
                    {
                        roueScript2 = child2.GetComponent<roue_pami1>();
                        Debug.Log($"roueScript: {roueScript2}");
                    }
                }
            } // then, same for "roue 1"
            else if (child.name == "roue 1")
            {
                foreach (Transform child1 in child)
                {
                    Debug.Log($"child1: {child1}");
                    if (child1.name == "Inner-Node-roue1")
                    {
                        roueScript1 = child1.GetComponent<roue_pami1>();
                        Debug.Log($"roueScript: {roueScript1}");
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (isMoving)
        {
            roueScript1.Move(true);
            roueScript2.Move(true);

            timer += Time.deltaTime;  // The interval in seconds from the last frame to the current one (Read Only).

            if (timer < waitTime1)
                transform.position += new Vector3(0, 0, moveSpeed);
            else if (timer < waitTime2 + waitTime1)
                transform.position += new Vector3(moveSpeed, 0, moveSpeed);
            else if (timer < waitTime3 + waitTime2 + waitTime1)
            {
                transform.position += new Vector3(-moveSpeed, 0, 0);
            }




            if (timer > waitTime3 + waitTime2 + waitTime1)
            {
                isMoving = false;
                roueScript1.Move(false);
                roueScript2.Move(false);
                float degrees = 90;
                //Vector3 to = new Vector3(0, degrees, 0);
                // transform.rotation = Quaternion.Euler(to);
                transform.Rotate(0, degrees, 0);
            }
        }

        if (Input.GetKey(KeyCode.F))
        {
            isMoving = true;
        }
    }
}