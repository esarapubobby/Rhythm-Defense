using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
