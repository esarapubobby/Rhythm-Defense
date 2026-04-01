using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
             Debug.Log("Badri");
            gameOverPanel.SetActive(true);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" )
        {
            Debug.Log("Badri");
            gameOverPanel.SetActive(true);
        }
    }
}
