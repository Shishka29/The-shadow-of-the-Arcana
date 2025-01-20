using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class carddelite2 : MonoBehaviour
{
    public GameObject card10;
    public GameObject card11;
    public GameObject card12;
    public GameObject card13;
    public GameObject card14;
    // Start is called before the first frame update
    void Start()
    {
        if (card10saver.card10save)
        {
            Destroy(card10);
        }
        if (card11saver.card11save)
        {
            Destroy(card11);
        }
        if (card12saver.card12save)
        {
            Destroy(card12);
        }
        if (card13saver.card13save)
        {
            Destroy(card13);
        }
        if (card14saver.card14save)
        {
            Destroy(card14);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
