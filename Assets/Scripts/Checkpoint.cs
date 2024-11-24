using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    public Transform player;
    public int index;

    // Start is called before the first frame update
    void Awake()
    { 
        if (DataContainer.checkpointindex == index)
        {
            player.position = transform.position;
        }
    }




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="Player")
        {   if (index> DataContainer.checkpointindex)
                DataContainer.checkpointindex = index;
        }
    }
}
