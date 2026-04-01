using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercollect : MonoBehaviour
{

    public TrashProgress progress;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trash"))
        {
            progress.AddTrash();
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Bomb"))
        {
            progress.HitBomb();
            Destroy(other.gameObject);
        }
    }

}
