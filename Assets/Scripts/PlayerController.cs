using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float verticalInput;
    public float turnSpeed = 40.0f;
    public float zMax = 450f;


    
    // Para q siempre empiece en la posicion zero
    void Start()
    {
        transform.position = Vector3.zero;

    }

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        // Movimiento horizontal del player
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Rotacion del player
        transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime * verticalInput);

        //Muestra este mensaje cuando llega a 450
        if (transform.position.z > zMax)
        {
            Debug.Log("THE END");
            Time.timeScale = 0;
        }
    }
}
