using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    void Start()
    {
        offset = new Vector3(0f, 5.21f, -14.57f); 
    }

    void LateUpdate() 
    {
        transform.position = plane.transform.position + offset;
    }
}
