using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class carddelite4 : MonoBehaviour
{
    public GameObject card20;
    public GameObject card21;
    
    // Start is called before the first frame update
    void Start()
    {
        if (card20saver.card20save)
        {
            Destroy(card20);
        }
        if (card21saver.card21save)
        {
            Destroy(card21);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
