using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject gameObjectToMove;



    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            gameObjectToMove.transform.localRotation = Quaternion.Euler(0, 360, 0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObjectToMove.transform.localRotation = Quaternion.Euler(0, 180, 0);

        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObjectToMove.transform.localRotation = Quaternion.Euler(0, 270, 0);

        }
        if (Input.GetKey(KeyCode.W))
        {
            gameObjectToMove.transform.localRotation = Quaternion.Euler(0, 90, 0);

        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            gameObjectToMove.transform.localRotation = Quaternion.Euler(0, 30, 0);

        }
    }
}
