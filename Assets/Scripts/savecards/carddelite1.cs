using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class carddelite1 : MonoBehaviour
{
    public GameObject card5;
    public GameObject card6;
    public GameObject card7;
    public GameObject card8;
    public GameObject card9;
    // Start is called before the first frame update
    void Start()
    {
        if (card5saver.card5save)
        {
            Destroy(card5);
        }
        if (card6saver.card6save)
        {
            Destroy(card6);
        }
        if (card7saver.card7save)
        {
            Destroy(card7);
        }
        if (card8saver.card8save)
        {
            Destroy(card8);
        }
        if (card9saver.card9save)
        {
            Destroy(card9);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
