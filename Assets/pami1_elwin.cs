using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pami1_elwin : MonoBehaviour
{

    Rigidbody rb;
    roue_pami1 roueScript;

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
                        roueScript = child2.GetComponent<roue_pami1>();
                        Debug.Log($"roueScript: {roueScript}");
                    }
                }
            }
        }


        // Log debug of the type of roueScript
        if (roueScript == null)
            Debug.Log("roueScript is null");
        else
            Debug.Log($"roueScript.GetType(): {roueScript.GetType()}");
    }

    // Update is called once per frame
    void Update()
    {

        if (isMoving)
        {

            Debug.Log($"isMoving: {isMoving}");
            Debug.Log($"timer: {timer}");
            Debug.Log($"waitTime1: {waitTime1}");
            Debug.Log($"Time.deltaTime: {Time.deltaTime}");

            timer += Time.deltaTime;  // The interval in seconds from the last frame to the current one (Read Only).
            // D'abord, l'objet se déplace tout droit vers la scène

            if (timer < waitTime1)
                transform.position += new Vector3(0, 0, moveSpeed);
            else if (timer < waitTime2 + waitTime1)
                transform.position += new Vector3(moveSpeed, 0, moveSpeed);
            else if (timer < waitTime3 + waitTime2 + waitTime1)
                transform.position += new Vector3(-moveSpeed, 0, 0);
            else
            {
                isMoving = false;
                roueScript.Move(false);
            }

        }

        if (Input.GetKey(KeyCode.F))
        {
            isMoving = true;
            roueScript.Move(true);
        }
    }
}