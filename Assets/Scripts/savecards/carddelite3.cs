using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class carddelite3 : MonoBehaviour
{
    public GameObject card15;
    public GameObject card16;
    public GameObject card17;
    public GameObject card18;
    public GameObject card19;
    // Start is called before the first frame update
    void Start()
    {
        if (card15saver.card15save)
        {
            Destroy(card15);
        }
        if (card16saver.card16save)
        {
            Destroy(card16);
        }
        if (card17saver.card17save)
        {
            Destroy(card17);
        }
        if (card18saver.card18save)
        {
            Destroy(card18);
        }
        if (card19saver.card19save)
        {
            Destroy(card19);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
