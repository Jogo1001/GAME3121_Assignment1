using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float propellerSpeed = 500f;

    void Update()
    {
     
        transform.Rotate(Vector3.forward * propellerSpeed * Time.deltaTime);
    }
}
