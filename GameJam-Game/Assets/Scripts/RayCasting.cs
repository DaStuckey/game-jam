using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting : MonoBehaviour
{
    
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitinfo, 20f))
        {
            Debug.Log("Hit Something");


        }
        else Debug.Log("Hit Nothing");
    }
}
