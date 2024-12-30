using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pami1_elwin : MonoBehaviour
{

    Rigidbody rb;

    // Ficelle booléenne pour déclencher le mouvement
    private bool isMoving = false;

    public float moveSpeed = 0.01f;

    private float timer = 0.0f;

    // Premier mouvement de l'objet pendant 1.25 secondes
    private float waitTime1 = 1.25f;
    private bool premier_mouvement = true;

    // Deuxième mouvement de l'objet pendant 2 secondes
    private float waitTime2 = 2.0f;
    private bool deuxieme_mouvement = true;



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

            Debug.Log($"isMoving: {isMoving}");
            timer += Time.deltaTime;  // The interval in seconds from the last frame to the current one (Read Only).
            // D'abord, l'objet se déplace tout droit vers la scène
            if (timer < waitTime1 && premier_mouvement)
                transform.position += new Vector3(0, 0, moveSpeed);
            else
                premier_mouvement = false;
                timer = 0.0f;


            // Ensuite l'objet se déplace en diagonale vers la droite de la scène
            if (timer < waitTime2 && !premier_mouvement && deuxieme_mouvement)
                transform.position += new Vector3(moveSpeed, 0, moveSpeed);
            else
                deuxieme_mouvement = false;
                timer = 0.0f;
        }

        if (Input.GetKey(KeyCode.F))
        {
            isMoving = true;
        }
    }
}