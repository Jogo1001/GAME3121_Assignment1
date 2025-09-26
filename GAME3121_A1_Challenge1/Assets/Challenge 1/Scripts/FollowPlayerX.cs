using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    void Start()
    {
        offset = new Vector3(15.49f, 2.31f, 2.33f); 
    }

    void LateUpdate() 
    {
        transform.position = plane.transform.position + offset;
    }
}
