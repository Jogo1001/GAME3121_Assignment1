using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 15.0f;
    public float rotationSpeed = 45.0f;
    public float verticalInput;

    void FixedUpdate()
    {
       
        verticalInput = Input.GetAxis("Vertical");

        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
    }
}
